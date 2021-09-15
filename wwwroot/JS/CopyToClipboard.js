window.clipboardCopy = (dateValue) => {
    navigator.clipboard.writeText(dateValue).catch(function (error) {
        alert(error);
    });
};