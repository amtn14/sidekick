var sidekick = {
    layout: {}, 
    page: {
        handlers: {}, 
        startUp: null
    }, 
    services: {}
};

if (sidekick.page.startUp == null) {
    sidekick.page.startUp = function () {
        $(document).ready(function () {
            console.log("Page is ready via jQuery!");
        });
    };
}
