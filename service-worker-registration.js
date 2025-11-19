// Only register SW in production (not localhost)
if ('serviceWorker' in navigator && !window.location.hostname.includes('localhost')) {
    navigator.serviceWorker.register('service-worker.js')
        .then(() => console.log('Service worker registered.'))
        .catch(err => console.warn('SW registration failed:', err));
} else {
    console.log('Service worker not registered on localhost.');
}
