function copyToClipboard(elementId, event) {
    const text = document.getElementById(elementId).innerText;
    navigator.clipboard.writeText(text).then(function () {
        const btn = event.target;
        const original = btn.innerHTML;
        btn.innerHTML = "✅";
        setTimeout(() => {
            btn.innerHTML = original;
        }, 1500);
    }, function (err) {
        alert('Kopyalanamadı!');
    });
}
