using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D4 RID: 1748
	public class TransitEntitySelector : MonoBehaviour
	{
		// Token: 0x06009D40 RID: 40256 RVA: 0x0027C8FC File Offset: 0x0027AAFC
		// Note: this type is marked as 'beforefieldinit'.
		static TransitEntitySelector()
		{
			Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "TransitEntitySelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr);
			TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "SELECTION_RANGE");
			TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			TransitEntitySelector.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "DetectionMask");
			TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "HoverOutlineColor");
			TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "SelectOutlineColor");
			TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "maxSelectedObjects");
			TransitEntitySelector.NativeFieldInfoPtr_selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectedObjects");
			TransitEntitySelector.NativeFieldInfoPtr_typeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "typeRequirements");
			TransitEntitySelector.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "objectFilter");
			TransitEntitySelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "callback");
			TransitEntitySelector.NativeFieldInfoPtr_hoveredObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "hoveredObj");
			TransitEntitySelector.NativeFieldInfoPtr_highlightedObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "highlightedObj");
			TransitEntitySelector.NativeFieldInfoPtr_selectionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectionTitle");
			TransitEntitySelector.NativeFieldInfoPtr_changesMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "changesMade");
			TransitEntitySelector.NativeFieldInfoPtr_transitSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "transitSources");
			TransitEntitySelector.NativeFieldInfoPtr_transitLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "transitLines");
			TransitEntitySelector.NativeFieldInfoPtr_selectDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectDestination");
			TransitEntitySelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682591);
			TransitEntitySelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682592);
			TransitEntitySelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682593);
			TransitEntitySelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682594);
			TransitEntitySelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682595);
			TransitEntitySelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682596);
			TransitEntitySelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682597);
			TransitEntitySelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682598);
			TransitEntitySelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682599);
			TransitEntitySelector.NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682600);
			TransitEntitySelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682601);
			TransitEntitySelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682602);
			TransitEntitySelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682603);
			TransitEntitySelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682604);
			TransitEntitySelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682605);
			TransitEntitySelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100682606);
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x06009D41 RID: 40257 RVA: 0x0027CBC0 File Offset: 0x0027ADC0
		// (set) Token: 0x06009D42 RID: 40258 RVA: 0x0027CBFC File Offset: 0x0027ADFC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x0027CC3C File Offset: 0x0027AE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278970, XrefRangeEnd = 278992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D44 RID: 40260 RVA: 0x0027CC70 File Offset: 0x0027AE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278992, XrefRangeEnd = 279073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<ITransitEntity> _selectedObjects, List<Type> _typeRequirements, TransitEntitySelector.ObjectFilter _objectFilter, Action<List<ITransitEntity>> _callback, List<Transform> transitLineSources = null, bool selectingDestination = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(instruction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxSelectedObjects;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedObjects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_typeRequirements);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_objectFilter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transitLineSources);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectingDestination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitEntitySelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x0027CD4C File Offset: 0x0027AF4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279111, RefRangeEnd = 279113, XrefRangeStart = 279073, XrefRangeEnd = 279111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransitLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x0027CD80 File Offset: 0x0027AF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279113, XrefRangeEnd = 279174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(bool returnToClipboard, bool pushChanges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnToClipboard;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushChanges;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitEntitySelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x0027CDD8 File Offset: 0x0027AFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279174, XrefRangeEnd = 279227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D48 RID: 40264 RVA: 0x0027CE0C File Offset: 0x0027B00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279227, XrefRangeEnd = 279228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D49 RID: 40265 RVA: 0x0027CE40 File Offset: 0x0027B040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279252, RefRangeEnd = 279254, XrefRangeStart = 279228, XrefRangeEnd = 279252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x0027CE74 File Offset: 0x0027B074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279254, XrefRangeEnd = 279260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITransitEntity GetHoveredObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x0027CEB4 File Offset: 0x0027B0B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279277, RefRangeEnd = 279280, XrefRangeStart = 279260, XrefRangeEnd = 279277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectTypeValid(ITransitEntity obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009D4C RID: 40268 RVA: 0x0027CF1C File Offset: 0x0027B11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279302, RefRangeEnd = 279303, XrefRangeStart = 279280, XrefRangeEnd = 279302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectClicked(ITransitEntity obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D4D RID: 40269 RVA: 0x0027CF60 File Offset: 0x0027B160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279307, RefRangeEnd = 279308, XrefRangeStart = 279303, XrefRangeEnd = 279307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectionOutline(ITransitEntity obj, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D4E RID: 40270 RVA: 0x0027CFB0 File Offset: 0x0027B1B0
		[CallerCount(0)]
		public unsafe void ClipboardClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D4F RID: 40271 RVA: 0x0027CFE4 File Offset: 0x0027B1E4
		[CallerCount(0)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D50 RID: 40272 RVA: 0x0027D028 File Offset: 0x0027B228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279308, XrefRangeEnd = 279341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitEntitySelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x0004D26F File Offset: 0x0004B46F
		public TransitEntitySelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x06009D52 RID: 40274 RVA: 0x0027D064 File Offset: 0x0027B264
		// (set) Token: 0x06009D53 RID: 40275 RVA: 0x0004D278 File Offset: 0x0004B478
		public unsafe static float SELECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x06009D54 RID: 40276 RVA: 0x0027D080 File Offset: 0x0027B280
		// (set) Token: 0x06009D55 RID: 40277 RVA: 0x0004D286 File Offset: 0x0004B486
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x06009D56 RID: 40278 RVA: 0x0027D0A8 File Offset: 0x0027B2A8
		// (set) Token: 0x06009D57 RID: 40279 RVA: 0x0004D2A1 File Offset: 0x0004B4A1
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x06009D58 RID: 40280 RVA: 0x0027D0D0 File Offset: 0x0027B2D0
		// (set) Token: 0x06009D59 RID: 40281 RVA: 0x0004D2BC File Offset: 0x0004B4BC
		public unsafe Color HoverOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor)) = value;
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x06009D5A RID: 40282 RVA: 0x0027D0F8 File Offset: 0x0027B2F8
		// (set) Token: 0x06009D5B RID: 40283 RVA: 0x0004D2D7 File Offset: 0x0004B4D7
		public unsafe Color SelectOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor)) = value;
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x06009D5C RID: 40284 RVA: 0x0027D120 File Offset: 0x0027B320
		// (set) Token: 0x06009D5D RID: 40285 RVA: 0x0004D2F2 File Offset: 0x0004B4F2
		public unsafe int maxSelectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects)) = value;
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x06009D5E RID: 40286 RVA: 0x0027D148 File Offset: 0x0027B348
		// (set) Token: 0x06009D5F RID: 40287 RVA: 0x0004D30D File Offset: 0x0004B50D
		public unsafe List<ITransitEntity> selectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x06009D60 RID: 40288 RVA: 0x0027D178 File Offset: 0x0027B378
		// (set) Token: 0x06009D61 RID: 40289 RVA: 0x0004D32C File Offset: 0x0004B52C
		public unsafe List<Type> typeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_typeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_typeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x06009D62 RID: 40290 RVA: 0x0027D1A8 File Offset: 0x0027B3A8
		// (set) Token: 0x06009D63 RID: 40291 RVA: 0x0004D34B File Offset: 0x0004B54B
		public unsafe TransitEntitySelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitEntitySelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x06009D64 RID: 40292 RVA: 0x0027D1D8 File Offset: 0x0027B3D8
		// (set) Token: 0x06009D65 RID: 40293 RVA: 0x0004D36A File Offset: 0x0004B56A
		public unsafe Action<List<ITransitEntity>> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<ITransitEntity>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x06009D66 RID: 40294 RVA: 0x0027D208 File Offset: 0x0027B408
		// (set) Token: 0x06009D67 RID: 40295 RVA: 0x0004D389 File Offset: 0x0004B589
		public unsafe ITransitEntity hoveredObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_hoveredObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_hoveredObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x06009D68 RID: 40296 RVA: 0x0027D238 File Offset: 0x0027B438
		// (set) Token: 0x06009D69 RID: 40297 RVA: 0x0004D3A8 File Offset: 0x0004B5A8
		public unsafe ITransitEntity highlightedObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_highlightedObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_highlightedObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x06009D6A RID: 40298 RVA: 0x0027D268 File Offset: 0x0027B468
		// (set) Token: 0x06009D6B RID: 40299 RVA: 0x0004D3C7 File Offset: 0x0004B5C7
		public unsafe string selectionTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectionTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectionTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x06009D6C RID: 40300 RVA: 0x0027D290 File Offset: 0x0027B490
		// (set) Token: 0x06009D6D RID: 40301 RVA: 0x0004D3E6 File Offset: 0x0004B5E6
		public unsafe bool changesMade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_changesMade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_changesMade)) = value;
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x06009D6E RID: 40302 RVA: 0x0027D2B8 File Offset: 0x0027B4B8
		// (set) Token: 0x06009D6F RID: 40303 RVA: 0x0004D401 File Offset: 0x0004B601
		public unsafe List<Transform> transitSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x06009D70 RID: 40304 RVA: 0x0027D2E8 File Offset: 0x0027B4E8
		// (set) Token: 0x06009D71 RID: 40305 RVA: 0x0004D420 File Offset: 0x0004B620
		public unsafe List<TransitLineVisuals> transitLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TransitLineVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x06009D72 RID: 40306 RVA: 0x0027D318 File Offset: 0x0027B518
		// (set) Token: 0x06009D73 RID: 40307 RVA: 0x0004D43F File Offset: 0x0004B63F
		public unsafe bool selectDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectDestination)) = value;
			}
		}

		// Token: 0x04006999 RID: 27033
		private static readonly IntPtr NativeFieldInfoPtr_SELECTION_RANGE;

		// Token: 0x0400699A RID: 27034
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400699B RID: 27035
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x0400699C RID: 27036
		private static readonly IntPtr NativeFieldInfoPtr_HoverOutlineColor;

		// Token: 0x0400699D RID: 27037
		private static readonly IntPtr NativeFieldInfoPtr_SelectOutlineColor;

		// Token: 0x0400699E RID: 27038
		private static readonly IntPtr NativeFieldInfoPtr_maxSelectedObjects;

		// Token: 0x0400699F RID: 27039
		private static readonly IntPtr NativeFieldInfoPtr_selectedObjects;

		// Token: 0x040069A0 RID: 27040
		private static readonly IntPtr NativeFieldInfoPtr_typeRequirements;

		// Token: 0x040069A1 RID: 27041
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x040069A2 RID: 27042
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040069A3 RID: 27043
		private static readonly IntPtr NativeFieldInfoPtr_hoveredObj;

		// Token: 0x040069A4 RID: 27044
		private static readonly IntPtr NativeFieldInfoPtr_highlightedObj;

		// Token: 0x040069A5 RID: 27045
		private static readonly IntPtr NativeFieldInfoPtr_selectionTitle;

		// Token: 0x040069A6 RID: 27046
		private static readonly IntPtr NativeFieldInfoPtr_changesMade;

		// Token: 0x040069A7 RID: 27047
		private static readonly IntPtr NativeFieldInfoPtr_transitSources;

		// Token: 0x040069A8 RID: 27048
		private static readonly IntPtr NativeFieldInfoPtr_transitLines;

		// Token: 0x040069A9 RID: 27049
		private static readonly IntPtr NativeFieldInfoPtr_selectDestination;

		// Token: 0x040069AA RID: 27050
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040069AB RID: 27051
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040069AC RID: 27052
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040069AD RID: 27053
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0;

		// Token: 0x040069AE RID: 27054
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0;

		// Token: 0x040069AF RID: 27055
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x040069B0 RID: 27056
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040069B1 RID: 27057
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040069B2 RID: 27058
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructions_Private_Void_0;

		// Token: 0x040069B3 RID: 27059
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0;

		// Token: 0x040069B4 RID: 27060
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0;

		// Token: 0x040069B5 RID: 27061
		private static readonly IntPtr NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0;

		// Token: 0x040069B6 RID: 27062
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0;

		// Token: 0x040069B7 RID: 27063
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardClosed_Private_Void_0;

		// Token: 0x040069B8 RID: 27064
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040069B9 RID: 27065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B97 RID: 2967
		public sealed class ObjectFilter : MulticastDelegate
		{
			// Token: 0x0600DC2D RID: 56365 RVA: 0x0034125C File Offset: 0x0033F45C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectFilter()
			{
				Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "ObjectFilter");
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100682607);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100682608);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100682609);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100682610);
			}

			// Token: 0x0600DC2E RID: 56366 RVA: 0x003412D0 File Offset: 0x0033F4D0
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 65069, RefRangeEnd = 65108, XrefRangeStart = 65069, XrefRangeEnd = 65108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectFilter(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC2F RID: 56367 RVA: 0x0034132C File Offset: 0x0033F52C
			[CallerCount(0)]
			public unsafe bool Invoke(ITransitEntity obj, out string reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600DC30 RID: 56368 RVA: 0x00341394 File Offset: 0x0033F594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ITransitEntity obj, out string reason, AsyncCallback callback, Il2CppSystem.Object @object)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600DC31 RID: 56369 RVA: 0x00341424 File Offset: 0x0033F624
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600DC32 RID: 56370 RVA: 0x0006B408 File Offset: 0x00069608
			public ObjectFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009392 RID: 37778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009393 RID: 37779
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0;

			// Token: 0x04009394 RID: 37780
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0;

			// Token: 0x04009395 RID: 37781
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}
