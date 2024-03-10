import { eManagerTemplatePage } from './app.po';

describe('eManager App', function() {
  let page: eManagerTemplatePage;

  beforeEach(() => {
    page = new eManagerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
