function showAlert() {
    // Hiển thị alert
    const customAlert = document.getElementById('customAlert');
    customAlert.style.display = 'block';

    // Ẩn alert sau 5 giây
    setTimeout(() => {
        customAlert.style.display = 'none';
    }, 5000);
}

// Gọi hàm khi trang web được tải
window.onload = showAlert;