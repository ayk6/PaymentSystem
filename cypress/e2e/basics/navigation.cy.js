describe('Example: Visit and Find Elements', () => {
    it('should visit the kitchen sink example', () => {
        cy.visit('https://example.cypress.io');
        cy.get('h1').should('contain', 'Kitchen Sink');
    });
});

