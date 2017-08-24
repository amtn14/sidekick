//jquery ajax for toDo
if (!sidekick.services.toDo) {
    sidekick.services.toDo = {};
}

sidekick.services.toDo.insertTask = function (data, successHandler, errorHandler) {
    var url = "/api/toDo/insert";
    var settings = {
        cache: false,
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        data: data,
        success: successHandler,
        error: errorHandler,
        type: "POST"
    };
    $.ajax(url, settings);
}

sidekick.services.toDo.getAllTasks = function (successHandler, errorHandler) {
    var url = '/api/toDo/getAllTasks';
    var settings = {
        cache: false,
        data: null,
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        success: successHandler,
        error: errorHandler,
        type: 'GET'
    };
    $.ajax(url, settings);
}