using XF.NET;

namespace XF.NET.Endpoints;

public sealed class ConversationMessagesXFEndpoint : XFEndpoint
{

    /// <summary>
    /// POST conversation-messages/
    /// Replies to a conversation
    /// <param name="conversation_id"></param>
    /// <param name="message"></param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key content type must be conversation_message with context[conversation_id] set to this conversation ID.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['message', 'ConversationMessage', 'The newly inserted message']</returns>
    /// </summary>

    /// <summary>
    /// GET conversation-messages/{id}/
    /// Gets the specified conversation message.
    /// <returns>['message', 'ConversationMessage', '']</returns>
    /// </summary>

    /// <summary>
    /// POST conversation-messages/{id}/
    /// Updates the specified conversation message.
    /// <param name="message">The new message content</param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key content type must be conversation_message with context[message_id] set to this message ID.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['message', 'ConversationMessage', '']</returns>
    /// </summary>

    /// <summary>
    /// POST conversation-messages/{id}/react
    /// Reacts to the specified conversation message
    /// <param name="reaction_id">ID of the reaction to use. Use the current reaction ID to undo.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['action', 'string', '"insert" or "delete" based on whether the reaction was added or removed.']</returns>
    /// </summary>
}
