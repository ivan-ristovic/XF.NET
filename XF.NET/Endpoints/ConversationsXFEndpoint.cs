using XF.NET;

namespace XF.NET.Endpoints;

public sealed class ConversationsXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET conversations/
    /// Gets the API user's list of conversations.
    /// <param name="page"></param>
    /// <param name="starter_id"></param>
    /// <param name="receiver_id"></param>
    /// <param name="starred">Only gets starred conversations if specified</param>
    /// <param name="unread">Only gets unread conversations if specified</param>
    /// <returns>['conversations', 'Conversation[]', '']</returns>
    /// <returns>['pagination', 'pagination', '']</returns>
    /// </summary>

    /// <summary>
    /// POST conversations/
    /// Creates a conversation
    /// <param name="recipient_ids">List of user IDs to send the conversation to</param>
    /// <param name="title">Conversation title</param>
    /// <param name="message">Conversation message body</param>
    /// <param name="attachment_key">API attachment key to upload files. Attachment key content type must be conversation_message with no context.</param>
    /// <param name="conversation_open">If false, no replies may be made to this conversation.</param>
    /// <param name="open_invite">If true, any member of the conversation may add others</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['conversation', 'Conversation', '']</returns>
    /// </summary>

    /// <summary>
    /// GET conversations/{id}/
    /// Gets information about the specified conversation.
    /// <param name="with_messages">If specified, the response will include a page of messages.</param>
    /// <param name="page">The page of messages to include</param>
    /// <returns>['conversation', 'Conversation', '']</returns>
    /// <returns>['messages', 'ConversationMessage[]', 'List of messages on the requested page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination details']</returns>
    /// </summary>

    /// <summary>
    /// POST conversations/{id}/
    /// Updates the specified conversation
    /// <param name="title">Conversation title</param>
    /// <param name="open_invite">If true, any member of the conversation can add others</param>
    /// <param name="conversation_open">If false, no further replies are allowed.</param>
    /// <returns>['success', 'true', '']</returns>
    /// <returns>['conversation', 'Conversation', '']</returns>
    /// </summary>

    /// <summary>
    /// DELETE conversations/{id}/
    /// Deletes the specified conversation from the API user's list. Does not delete the conversation for other receivers.
    /// <param name="ignore">If true, further replies to this conversation will be ignored. (Otherwise, replies will restore this conversation to the list.)</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST conversations/{id}/invite
    /// Invites the specified users to this conversation.
    /// <param name="recipient_ids">List of user IDs to invite</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST conversations/{id}/mark-read
    /// Marks the conversation as read up until the specified time. This cannot move the
    /// <param name="date">Unix timestamp to mark the conversation read to. If not specified, defaults to the current time.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// POST conversations/{id}/mark-unread
    /// Marks a conversation as unread. This will mark all messages in the conversation as unread.
    /// <returns>['success', 'true', '']</returns>
    /// </summary>

    /// <summary>
    /// GET conversations/{id}/messages
    /// Gets a page of messages in the specified conversation.
    /// <param name="page"></param>
    /// <returns>['messages', 'ConversationMessage[]', 'List of messages on the requested page']</returns>
    /// <returns>['pagination', 'pagination', 'Pagination details']</returns>
    /// </summary>

    /// <summary>
    /// POST conversations/{id}/star
    /// Sets the star status of the specified conversation
    /// <param name="star">If provided, sets the star status as specified. If not provided, toggles the status.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>
}
