describe('DOM Interactions', () => {
    beforeEach(() => {
        cy.visit('/commands/actions');
    });

    it('should click a button', () => {
        cy.get('.action-btn')
            .click()
            .should('have.class', 'btn-success');
    });

    it('should type into an input field', () => {
        cy.get('.action-email')
            .type('test@example.com')
            .should('have.value', 'test@example.com');
    });

    it('should clear an input field', () => {
        cy.get('.action-email')
            .type('something')
            .clear()
            .should('have.value', '');
    });
});

