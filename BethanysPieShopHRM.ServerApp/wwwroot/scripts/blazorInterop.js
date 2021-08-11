// The || operator appends the current defnition to any existing definition
// Failure to user || results in the current definition replacing any existing

var blazorInterop = blazorInterop || {};

blazorInterop.showAlert = function (message) {
    alert(message);
};

blazorInterop.logToConsoleTable = function (obj) {
    console.table(obj);
}

blazorInterop.showPrompt = function (message, defaultValue) {
    return prompt(message, defaultValue);
}

blazorInterop.createEmployee = function (firstName, lastName){
    return { firstName, lastName, email: firstName + "@cassinisoft.com" };
};

blazorInterop.focusElement = (element) => element.focus();

blazorInterop.focusElementById = (id) => {
    element = document.getElementById(id);
    if (element) {
        element.focus();
    }
};

blazorInterop.throwsError = () => {
    throw Error("Sean didn't implment correct function!");
};
