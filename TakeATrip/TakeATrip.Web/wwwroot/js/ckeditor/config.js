/**
 * @license Copyright (c) 2003-2018, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
	// config.uiColor = '#AADC6E';

    config.filebrowserBrowseUrl = '/js/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/js/ckfinder/ckfinder.html?type=Images';
    config.filebrowserFlashBrowseUrl = '/js/ckfinder/ckfinder.html?type=Flash';
    config.extraPlugins = 'uploadimage';
    //config.filebrowserUploadUrl = '/js/ckeditor/plugins/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    //config.filebrowserImageUploadUrl = '/js/ckeditor/plugins/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images';
    //config.filebrowserFlashUploadUrl = '/js/ckeditor/plugins/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
    //CKFinder.setupCKEditor(null, '/js/ckfinder');

    CKFinder.setupCKEditor()
};

