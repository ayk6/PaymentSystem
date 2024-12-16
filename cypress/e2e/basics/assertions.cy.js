describe('Assertions in Cypress', () => {
    it('should assert visibility and class', () => {
        cy.visit('https://example.cypress.io/commands/assertions');
        cy.get('.assertion-table').should('be.visible').and('have.class', 'table');
    });

    it('should check text content', () => {
        cy.get('.assertion-heading').should('contain', 'Assertions');
    });
});
