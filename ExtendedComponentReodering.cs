using UnityEngine;
using UnityEditor;

public class ExtendedComponentReodering  {
    [MenuItem("CONTEXT/Component/Move To Top")]
    private static void MoveToTop(MenuCommand menuCommand)
    {
        Component c = (Component)menuCommand.context;
        Component[] allComponents = c.GetComponents<Component>();
        int iOffset = 0;
        for(int i=0; i < allComponents.Length; i++)
        {
            if(allComponents[i] == c)
            {
                iOffset = i;
                break;
            }
        }
        for(int i =0; i < iOffset -1; i++)
        {
            UnityEditorInternal.ComponentUtility.MoveComponentUp(c);
        }
        EditorApplication.MarkSceneDirty();
    }
    [MenuItem("CONTEXT/Component/Move To Bottom")]
    private static void MoveToBottom(MenuCommand menuCommand)
    {
        Component c = (Component)menuCommand.context;
        Component[] allComponents = c.GetComponents<Component>();
        int iOffset = 0;
        for (int i = 0; i < allComponents.Length; i++)
        {
            if (allComponents[i] == c)
            {
                iOffset = i;
                break;
            }
        }
        for (; iOffset < allComponents.Length; iOffset++)
        {
            UnityEditorInternal.ComponentUtility.MoveComponentDown(c);
        }
        EditorApplication.MarkSceneDirty();
    }
}
