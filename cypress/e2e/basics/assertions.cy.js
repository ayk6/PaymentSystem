describe('Assertions in Cypress', () => {

    beforeEach(() => {
        cy.visit('/commands/assertions');
    });

    it('should assert visibility and class', () => {
        cy.get('.assertion-table').should('be.visible').and('have.class', 'table');
    });

    it('should assert header visibility and contain', () => {
        cy.get('.banner > .container > h1').should('be.visible').and('contain', 'Assertions');
    });

    it('and command', () => {
        cy.get('.assertions-link')
            .should('have.class', 'active')
            .and('have.attr', 'href')
            .and('include', 'cypress.io')
    });
});
