describe('Form Input Testing', () => {
    it('Fills and submits a form', () => {
        cy.visit('https://example.cypress.io/commands/actions');
        cy.get('.action-email') // Email giriş kutusunu seç
            .type('test@example.com') // Email adresi yaz
            .should('have.value', 'test@example.com'); // Değeri doğrula

        cy.get('.action-form') // Formu seç
            .submit(); // Gönder

        cy.get('.action-success') // Başarı mesajını kontrol et
            .should('contain', 'Your form has been submitted!');
    });
});
