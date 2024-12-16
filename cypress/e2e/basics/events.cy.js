describe('Mouse and Keyboard Events', () => {

    beforeEach(() => {
        cy.visit('/commands/actions');
    });

    it('should be typed', () => {
        cy.get('.action-email').type('fake@email.com')
        cy.get('.action-email').should('have.value', 'fake@email.com')
    });

    it('should be focused', () => {
        cy.get('.action-focus').focus()
        cy.get('.action-focus').should('have.class', 'focus')
            .prev().should('have.attr', 'style', 'color: orange;')
    });

    it('clear text', () => {
        cy.get('.action-clear').type('Clear this text')
        cy.get('.action-clear').should('have.value', 'Clear this text')
        cy.get('.action-clear').clear()
        cy.get('.action-clear').should('have.value', '')
    });

    it('scroll to top', () => {
        cy.scrollTo('top')
    });


    it('should be clicked', () => {
        cy.get('.action-btn').click()
        cy.get('.popover').should('be.visible')
    });


    it('should be double clicked', () => {
        cy.get('.action-div').dblclick()
        cy.get('.action-div').should('not.be.visible')
        cy.get('.action-input-hidden').should('be.visible')
    });
});
