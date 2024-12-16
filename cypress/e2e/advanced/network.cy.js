describe('Network Requests', () => {
    it('should intercept and modify a response', () => {
        cy.visit('https://example.cypress.io/commands/network-requests');

        cy.intercept('GET', '/comments/*', {
            statusCode: 200,
            body: { id: 1, name: 'Modified User' },
        }).as('getComment');

        cy.get('.network-btn').click();
        cy.wait('@getComment').its('response.body').should('have.property', 'name', 'Modified User');
    });
});
