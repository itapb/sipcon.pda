Before Publish from Visual studio to IIS
\wwwroot\index.html 
To change <base href="/" /> to <base href="/sipconmobileapp/" />

IIS sipconmobileapp -> \web.config addition for .webmanifest MIME type
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <system.webServer>
    <staticContent>
       ....
      <remove fileExtension=".webmanifest" />
      <mimeMap fileExtension=".webmanifest" mimeType="application/manifest+json" /> ADD this line
    </staticContent>
      

  </system.webServer>
</configuration>

In any cases, remote Changan IIS:
To replace <script>navigator.serviceWorker.register('service-worker.js', { updateViaCache: 'none' });</script> with the following code:
<script>
  (function () {
    try {
      if (typeof window === 'undefined' || typeof navigator === 'undefined')
        return;

      // Only register on top-level window (not in an iframe), and only if browser supports SW
      if (window.self !== window.top) {
        console.debug('Skipping service worker registration: running in an iframe.');
        return;
      }

      if (!('serviceWorker' in navigator)) {
        console.debug('Service Worker API not available in this browser / context.');
        return;
      }

      const baseHref = document.querySelector('base')?.getAttribute('href') ?? '/';
      const swUrl = new URL('service-worker.js', baseHref).toString();

      // Optional: verify that the SW file exists before attempting registration (avoids some 404 logs)
      fetch(swUrl, { method: 'HEAD' })
        .then(resp => {
          if (!resp.ok) {
            console.warn(`Service worker script not found at ${swUrl} (status: ${resp.status}). Skipping registration.`);
            return;
          }
          return navigator.serviceWorker.register(swUrl, { updateViaCache: 'none' })
            .then(reg => console.log('Service worker registered:', reg.scope))
            .catch(err => console.warn('Service worker registration failed:', err));
        })
        .catch(err => console.warn('Failed to verify service-worker.js before register:', err));
    } catch (err) {
      console.warn('Service worker registration error:', err);
    }
  })();
</script>