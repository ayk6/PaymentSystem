describe('Mouse and Keyboard Events', () => {
    it('should hover over an element', () => {
        cy.visit('https://example.cypress.io/commands/actions');
        cy.get('.action-hover').trigger('mouseover').should('have.css', 'color', 'rgb(255, 255, 255)');
    });

    it('should right-click on an element', () => {
        cy.get('.rightclick-action').rightclick().should('have.class', 'context-menu');
    });
});
