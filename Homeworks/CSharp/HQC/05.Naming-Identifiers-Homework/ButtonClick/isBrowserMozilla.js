function isBrowserMozilla() {
    var clientWindow = window,
        client = clientWindow.navigator.appCodeName,
        isMozilla = client === "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}