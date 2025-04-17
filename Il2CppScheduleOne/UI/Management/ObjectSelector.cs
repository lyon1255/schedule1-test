using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D1 RID: 1745
	public class ObjectSelector : MonoBehaviour
	{
		// Token: 0x06009CE2 RID: 40162 RVA: 0x0027B734 File Offset: 0x00279934
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelector()
		{
			Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ObjectSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr);
			ObjectSelector.NativeFieldInfoPtr_SELECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "SELECTION_RANGE");
			ObjectSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			ObjectSelector.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "DetectionMask");
			ObjectSelector.NativeFieldInfoPtr_HoverOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "HoverOutlineColor");
			ObjectSelector.NativeFieldInfoPtr_SelectOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "SelectOutlineColor");
			ObjectSelector.NativeFieldInfoPtr_maxSelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "maxSelectedObjects");
			ObjectSelector.NativeFieldInfoPtr_selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectedObjects");
			ObjectSelector.NativeFieldInfoPtr_typeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "typeRequirements");
			ObjectSelector.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "objectFilter");
			ObjectSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "callback");
			ObjectSelector.NativeFieldInfoPtr_hoveredObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "hoveredObj");
			ObjectSelector.NativeFieldInfoPtr_highlightedObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "highlightedObj");
			ObjectSelector.NativeFieldInfoPtr_selectionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectionTitle");
			ObjectSelector.NativeFieldInfoPtr_changesMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "changesMade");
			ObjectSelector.NativeFieldInfoPtr_transitSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "transitSources");
			ObjectSelector.NativeFieldInfoPtr_transitLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "transitLines");
			ObjectSelector.NativeFieldInfoPtr_targetProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "targetProperty");
			ObjectSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682556);
			ObjectSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682557);
			ObjectSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682558);
			ObjectSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_BuildableItem_List_1_Type_Property_ObjectFilter_Action_1_List_1_BuildableItem_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682559);
			ObjectSelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682560);
			ObjectSelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682561);
			ObjectSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682562);
			ObjectSelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682563);
			ObjectSelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682564);
			ObjectSelector.NativeMethodInfoPtr_GetHoveredObject_Private_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682565);
			ObjectSelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682566);
			ObjectSelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682567);
			ObjectSelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682568);
			ObjectSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682569);
			ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682570);
			ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100682571);
		}

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x06009CE3 RID: 40163 RVA: 0x0027B9F8 File Offset: 0x00279BF8
		// (set) Token: 0x06009CE4 RID: 40164 RVA: 0x0027BA34 File Offset: 0x00279C34
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x0027BA74 File Offset: 0x00279C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278396, XrefRangeEnd = 278418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x0027BAA8 File Offset: 0x00279CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278418, XrefRangeEnd = 278496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<BuildableItem> _selectedObjects, List<Type> _typeRequirements, Property property, ObjectSelector.ObjectFilter _objectFilter, Action<List<BuildableItem>> _callback, List<Transform> transitLineSources = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(instruction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxSelectedObjects;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedObjects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_typeRequirements);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_objectFilter);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transitLineSources);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_BuildableItem_List_1_Type_Property_ObjectFilter_Action_1_List_1_BuildableItem_List_1_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x0027BB88 File Offset: 0x00279D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278525, RefRangeEnd = 278527, XrefRangeStart = 278496, XrefRangeEnd = 278525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransitLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE8 RID: 40168 RVA: 0x0027BBBC File Offset: 0x00279DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278527, XrefRangeEnd = 278584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(bool returnToClipboard, bool pushChanges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnToClipboard;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushChanges;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x0027BC14 File Offset: 0x00279E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278584, XrefRangeEnd = 278642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CEA RID: 40170 RVA: 0x0027BC48 File Offset: 0x00279E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278642, XrefRangeEnd = 278643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CEB RID: 40171 RVA: 0x0027BC7C File Offset: 0x00279E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278667, RefRangeEnd = 278669, XrefRangeStart = 278643, XrefRangeEnd = 278667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CEC RID: 40172 RVA: 0x0027BCB0 File Offset: 0x00279EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278669, XrefRangeEnd = 278675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItem GetHoveredObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_GetHoveredObject_Private_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr3) : null;
		}

		// Token: 0x06009CED RID: 40173 RVA: 0x0027BCF0 File Offset: 0x00279EF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278694, RefRangeEnd = 278697, XrefRangeStart = 278675, XrefRangeEnd = 278694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectTypeValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009CEE RID: 40174 RVA: 0x0027BD58 File Offset: 0x00279F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278718, RefRangeEnd = 278719, XrefRangeStart = 278697, XrefRangeEnd = 278718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectClicked(BuildableItem obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CEF RID: 40175 RVA: 0x0027BD9C File Offset: 0x00279F9C
		[CallerCount(0)]
		public unsafe void SetSelectionOutline(BuildableItem obj, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CF0 RID: 40176 RVA: 0x0027BDEC File Offset: 0x00279FEC
		[CallerCount(0)]
		public unsafe void ClipboardClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CF1 RID: 40177 RVA: 0x0027BE20 File Offset: 0x0027A020
		[CallerCount(0)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CF2 RID: 40178 RVA: 0x0027BE64 File Offset: 0x0027A064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278719, XrefRangeEnd = 278752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CF3 RID: 40179 RVA: 0x0004CEC0 File Offset: 0x0004B0C0
		public ObjectSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x06009CF4 RID: 40180 RVA: 0x0027BEA0 File Offset: 0x0027A0A0
		// (set) Token: 0x06009CF5 RID: 40181 RVA: 0x0004CEC9 File Offset: 0x0004B0C9
		public unsafe static float SELECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ObjectSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x06009CF6 RID: 40182 RVA: 0x0027BEBC File Offset: 0x0027A0BC
		// (set) Token: 0x06009CF7 RID: 40183 RVA: 0x0004CED7 File Offset: 0x0004B0D7
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x06009CF8 RID: 40184 RVA: 0x0027BEE4 File Offset: 0x0027A0E4
		// (set) Token: 0x06009CF9 RID: 40185 RVA: 0x0004CEF2 File Offset: 0x0004B0F2
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x06009CFA RID: 40186 RVA: 0x0027BF0C File Offset: 0x0027A10C
		// (set) Token: 0x06009CFB RID: 40187 RVA: 0x0004CF0D File Offset: 0x0004B10D
		public unsafe Color HoverOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_HoverOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_HoverOutlineColor)) = value;
			}
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x06009CFC RID: 40188 RVA: 0x0027BF34 File Offset: 0x0027A134
		// (set) Token: 0x06009CFD RID: 40189 RVA: 0x0004CF28 File Offset: 0x0004B128
		public unsafe Color SelectOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_SelectOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_SelectOutlineColor)) = value;
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x06009CFE RID: 40190 RVA: 0x0027BF5C File Offset: 0x0027A15C
		// (set) Token: 0x06009CFF RID: 40191 RVA: 0x0004CF43 File Offset: 0x0004B143
		public unsafe int maxSelectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_maxSelectedObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_maxSelectedObjects)) = value;
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x06009D00 RID: 40192 RVA: 0x0027BF84 File Offset: 0x0027A184
		// (set) Token: 0x06009D01 RID: 40193 RVA: 0x0004CF5E File Offset: 0x0004B15E
		public unsafe List<BuildableItem> selectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x06009D02 RID: 40194 RVA: 0x0027BFB4 File Offset: 0x0027A1B4
		// (set) Token: 0x06009D03 RID: 40195 RVA: 0x0004CF7D File Offset: 0x0004B17D
		public unsafe List<Type> typeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_typeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_typeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x06009D04 RID: 40196 RVA: 0x0027BFE4 File Offset: 0x0027A1E4
		// (set) Token: 0x06009D05 RID: 40197 RVA: 0x0004CF9C File Offset: 0x0004B19C
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x06009D06 RID: 40198 RVA: 0x0027C014 File Offset: 0x0027A214
		// (set) Token: 0x06009D07 RID: 40199 RVA: 0x0004CFBB File Offset: 0x0004B1BB
		public unsafe Action<List<BuildableItem>> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<BuildableItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x06009D08 RID: 40200 RVA: 0x0027C044 File Offset: 0x0027A244
		// (set) Token: 0x06009D09 RID: 40201 RVA: 0x0004CFDA File Offset: 0x0004B1DA
		public unsafe BuildableItem hoveredObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x06009D0A RID: 40202 RVA: 0x0027C074 File Offset: 0x0027A274
		// (set) Token: 0x06009D0B RID: 40203 RVA: 0x0004CFF9 File Offset: 0x0004B1F9
		public unsafe BuildableItem highlightedObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_highlightedObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_highlightedObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x06009D0C RID: 40204 RVA: 0x0027C0A4 File Offset: 0x0027A2A4
		// (set) Token: 0x06009D0D RID: 40205 RVA: 0x0004D018 File Offset: 0x0004B218
		public unsafe string selectionTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x06009D0E RID: 40206 RVA: 0x0027C0CC File Offset: 0x0027A2CC
		// (set) Token: 0x06009D0F RID: 40207 RVA: 0x0004D037 File Offset: 0x0004B237
		public unsafe bool changesMade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_changesMade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_changesMade)) = value;
			}
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x06009D10 RID: 40208 RVA: 0x0027C0F4 File Offset: 0x0027A2F4
		// (set) Token: 0x06009D11 RID: 40209 RVA: 0x0004D052 File Offset: 0x0004B252
		public unsafe List<Transform> transitSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_transitSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_transitSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x06009D12 RID: 40210 RVA: 0x0027C124 File Offset: 0x0027A324
		// (set) Token: 0x06009D13 RID: 40211 RVA: 0x0004D071 File Offset: 0x0004B271
		public unsafe List<TransitLineVisuals> transitLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_transitLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TransitLineVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_transitLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x06009D14 RID: 40212 RVA: 0x0027C154 File Offset: 0x0027A354
		// (set) Token: 0x06009D15 RID: 40213 RVA: 0x0004D090 File Offset: 0x0004B290
		public unsafe Property targetProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_targetProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_targetProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006960 RID: 26976
		private static readonly IntPtr NativeFieldInfoPtr_SELECTION_RANGE;

		// Token: 0x04006961 RID: 26977
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006962 RID: 26978
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04006963 RID: 26979
		private static readonly IntPtr NativeFieldInfoPtr_HoverOutlineColor;

		// Token: 0x04006964 RID: 26980
		private static readonly IntPtr NativeFieldInfoPtr_SelectOutlineColor;

		// Token: 0x04006965 RID: 26981
		private static readonly IntPtr NativeFieldInfoPtr_maxSelectedObjects;

		// Token: 0x04006966 RID: 26982
		private static readonly IntPtr NativeFieldInfoPtr_selectedObjects;

		// Token: 0x04006967 RID: 26983
		private static readonly IntPtr NativeFieldInfoPtr_typeRequirements;

		// Token: 0x04006968 RID: 26984
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x04006969 RID: 26985
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400696A RID: 26986
		private static readonly IntPtr NativeFieldInfoPtr_hoveredObj;

		// Token: 0x0400696B RID: 26987
		private static readonly IntPtr NativeFieldInfoPtr_highlightedObj;

		// Token: 0x0400696C RID: 26988
		private static readonly IntPtr NativeFieldInfoPtr_selectionTitle;

		// Token: 0x0400696D RID: 26989
		private static readonly IntPtr NativeFieldInfoPtr_changesMade;

		// Token: 0x0400696E RID: 26990
		private static readonly IntPtr NativeFieldInfoPtr_transitSources;

		// Token: 0x0400696F RID: 26991
		private static readonly IntPtr NativeFieldInfoPtr_transitLines;

		// Token: 0x04006970 RID: 26992
		private static readonly IntPtr NativeFieldInfoPtr_targetProperty;

		// Token: 0x04006971 RID: 26993
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006972 RID: 26994
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006973 RID: 26995
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006974 RID: 26996
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_BuildableItem_List_1_Type_Property_ObjectFilter_Action_1_List_1_BuildableItem_List_1_Transform_0;

		// Token: 0x04006975 RID: 26997
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0;

		// Token: 0x04006976 RID: 26998
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x04006977 RID: 26999
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006978 RID: 27000
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006979 RID: 27001
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructions_Private_Void_0;

		// Token: 0x0400697A RID: 27002
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredObject_Private_BuildableItem_0;

		// Token: 0x0400697B RID: 27003
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x0400697C RID: 27004
		private static readonly IntPtr NativeMethodInfoPtr_ObjectClicked_Public_Void_BuildableItem_0;

		// Token: 0x0400697D RID: 27005
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionOutline_Private_Void_BuildableItem_Boolean_0;

		// Token: 0x0400697E RID: 27006
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardClosed_Private_Void_0;

		// Token: 0x0400697F RID: 27007
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006980 RID: 27008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B94 RID: 2964
		public sealed class ObjectFilter : MulticastDelegate
		{
			// Token: 0x0600DC17 RID: 56343 RVA: 0x00340D78 File Offset: 0x0033EF78
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectFilter()
			{
				Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "ObjectFilter");
				ObjectSelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr, 100682572);
				ObjectSelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr, 100682573);
				ObjectSelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuildableItem_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr, 100682574);
				ObjectSelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr, 100682575);
			}

			// Token: 0x0600DC18 RID: 56344 RVA: 0x00340DEC File Offset: 0x0033EFEC
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 65069, RefRangeEnd = 65108, XrefRangeStart = 65069, XrefRangeEnd = 65108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectFilter(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC19 RID: 56345 RVA: 0x00340E48 File Offset: 0x0033F048
			[CallerCount(0)]
			public unsafe bool Invoke(BuildableItem obj, out string reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600DC1A RID: 56346 RVA: 0x00340EB0 File Offset: 0x0033F0B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(BuildableItem obj, out string reason, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuildableItem_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600DC1B RID: 56347 RVA: 0x00340F40 File Offset: 0x0033F140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out string reason, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600DC1C RID: 56348 RVA: 0x0006B38B File Offset: 0x0006958B
			public ObjectFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009386 RID: 37766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009387 RID: 37767
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BuildableItem_byref_String_0;

			// Token: 0x04009388 RID: 37768
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuildableItem_byref_String_AsyncCallback_Object_0;

			// Token: 0x04009389 RID: 37769
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}
