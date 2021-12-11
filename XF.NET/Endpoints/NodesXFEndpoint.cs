using XF.NET;

namespace XF.NET.Endpoints;

public sealed class NodesXFEndpoint : XFEndpoint
{

    /// <summary>
    /// GET nodes/
    /// Gets the node tree.
    /// <returns>['tree_map', 'array', 'A mapping that connects node parent IDs to a list of their child node IDs']</returns>
    /// <returns>['nodes', 'Node[]', 'List of all nodes']</returns>
    /// </summary>

    /// <summary>
    /// POST nodes/
    /// Creates a new node
    /// <param name="node[title]"></param>
    /// <param name="node[node_name]"></param>
    /// <param name="node[description]"></param>
    /// <param name="node[parent_node_id]"></param>
    /// <param name="node[display_order]"></param>
    /// <param name="node[display_in_list]"></param>
    /// <param name="type_data">Type-specific node data. The available options will vary based on the node type involved.</param>
    /// <param name="node_type_id"></param>
    /// <returns>['node', 'Node', 'Information about the created node']</returns>
    /// </summary>

    /// <summary>
    /// GET nodes/flattened
    /// Gets a flattened node tree. Traversing this will return a list of nodes in the expected order.
    /// <returns>['nodes_flat', 'array', 'An array. Each entry contains keys of "node" and "depth"']</returns>
    /// </summary>

    /// <summary>
    /// GET nodes/{id}/
    /// Gets information about the specified node
    /// <returns>['node', 'Node', '']</returns>
    /// </summary>

    /// <summary>
    /// POST nodes/{id}/
    /// Updates the specified node
    /// <param name="node[title]"></param>
    /// <param name="node[node_name]"></param>
    /// <param name="node[description]"></param>
    /// <param name="node[parent_node_id]"></param>
    /// <param name="node[display_order]"></param>
    /// <param name="node[display_in_list]"></param>
    /// <param name="type_data">Type-specific node data. The available options will vary based on the node type involved.</param>
    /// <returns>['node', 'Node', 'The updated node information']</returns>
    /// </summary>

    /// <summary>
    /// DELETE nodes/{id}/
    /// Deletes the specified node
    /// <param name="delete_children">If true, child nodes will be deleted. Otherwise, they will be connected to this node's parent.</param>
    /// <returns>['success', 'true', '']</returns>
    /// </summary>
}
