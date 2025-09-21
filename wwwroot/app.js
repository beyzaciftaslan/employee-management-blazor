window.showModal = (modalId) => {
    console.log('showModal called for:', modalId);
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
        const modal = new bootstrap.Modal(modalElement);
        modal.show();
    } else {
        console.error('Modal element not found:', modalId);
    }
};

window.hideModal = (modalId) => {
    console.log('hideModal called for:', modalId);
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
        const modal = bootstrap.Modal.getInstance(modalElement);
        if (modal) {
            modal.hide();
        }
    }
};