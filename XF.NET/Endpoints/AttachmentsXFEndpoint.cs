using XF.NET;

namespace XF.NET.Endpoints;

public sealed class AttachmentsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET attachments/
    /// Gets the attachments associated with the provided API attachment key. Only returns attachments that have not been associated with content.
    /// <param name="key">The API attachment key</param>
    /// <returns>['attachments', 'Attachment[]', 'List of matching attachments.']</returns>
    /// </summary>

    /// <summary>
    /// POST attachments/
    /// Uploads an attachment. An API attachment key must be created first. Must be submitted using multipart/form-data encoding.
    /// <param name="key">The API attachment key to associated with</param>
    /// <param name="attachment">The attachment file</param>
    /// <returns>['attachment', 'Attachment', 'The attachment record of the successful upload']</returns>
    /// <returns>['Errors', '']</returns>
    /// <returns>['Error key', 'Description', '']</returns>
    /// <returns>['attachment_key_user_wrong', 'Triggered if the user making the request does not match the user that created the attachment key.', '']</returns>
    /// </summary>

    /// <summary>
    /// POST attachments/new-key
    /// Creates a new attachment key, allowing attachments to be uploaded separately from the related content.
    /// <param name="type">The content type of the attachment. Default types include post, conversation_message. Add-ons may add more.</param>
    /// <param name="context">Key-value pairs representing the context of the attachment. This will vary depending on content type and the action being taken. See relevant actions for further details.</param>
    /// <param name="attachment">The first attachment to be associated with the new key.</param>
    /// <returns>['key', 'string', 'The attachment key created. This should be used to upload additional files or to associate uploaded attachments with other content.']</returns>
    /// <returns>['attachment', 'Attachment', 'If a file was provided and the upload was successful, this will describe the new attachment.']</returns>
    /// </summary>

    /// <summary>
    /// GET attachments/{id}/
    /// Gets information about the specified attachment.
    /// <returns>['attachment', 'Attachment', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE attachments/{id}/
    /// Delete's the specified attachment.
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// GET attachments/{id}/data
    /// Gets the data that makes up the specified attachment. The output is the raw binary data.
    /// <returns>['data', 'binary', 'The binary data is output directly, not JSON.']</returns>
    /// </summary>

    /// <summary>
    /// GET attachments/{id}/thumbnail
    /// Gets the URL to the attachment's thumbnail, if it has one. URL returned via a 301 redirect.
    /// <returns>['url', 'string', "The URL to the thumbnail is returned via a 301 redirect's Location header."]</returns>
    /// <returns>['Errors', '']</returns>
    /// <returns>['Error key', 'Description', '']</returns>
    /// <returns>['not_found', 'Not found if the attachment does not have a thumbnail', '']</returns>
    /// </summary>
}
