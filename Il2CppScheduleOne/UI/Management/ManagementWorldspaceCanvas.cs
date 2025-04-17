using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CF RID: 1743
	public class ManagementWorldspaceCanvas : Singleton<ManagementWorldspaceCanvas>
	{
		// Token: 0x06009C93 RID: 40083 RVA: 0x0027A780 File Offset: 0x00278980
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementWorldspaceCanvas()
		{
			Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ManagementWorldspaceCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr);
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "VISIBILITY_RANGE");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "PROPERTY_CANVAS_RANGE");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<IsOpen>k__BackingField");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "Canvas");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ScaleCurve");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "TransitRouteVisualsPrefab");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "CrosshairPrompt");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ObjectSelectionLayerMask");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "HoveredOutlineColor");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "SelectedOutlineColor");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ShownConfigurables");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "HoveredConfigurable");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "OutlinedConfigurable");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "SelectedConfigurables");
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682520);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682521);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682522);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682523);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682524);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682525);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682526);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateUIs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682527);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682528);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682529);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682530);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682531);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_ClearSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682532);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682533);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682534);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682535);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682536);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682537);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100682538);
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x06009C94 RID: 40084 RVA: 0x0027AA44 File Offset: 0x00278C44
		// (set) Token: 0x06009C95 RID: 40085 RVA: 0x0027AA80 File Offset: 0x00278C80
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x0027AAC0 File Offset: 0x00278CC0
		public unsafe Property CurrentProperty
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 277741, RefRangeEnd = 277745, XrefRangeStart = 277737, XrefRangeEnd = 277741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x06009C97 RID: 40087 RVA: 0x0027AB00 File Offset: 0x00278D00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277762, RefRangeEnd = 277764, XrefRangeStart = 277745, XrefRangeEnd = 277762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x0027AB34 File Offset: 0x00278D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277778, RefRangeEnd = 277780, XrefRangeStart = 277764, XrefRangeEnd = 277778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveSelection = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preserveSelection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C99 RID: 40089 RVA: 0x0027AB74 File Offset: 0x00278D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277780, XrefRangeEnd = 277818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C9A RID: 40090 RVA: 0x0027ABA8 File Offset: 0x00278DA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277856, RefRangeEnd = 277858, XrefRangeStart = 277818, XrefRangeEnd = 277856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x0027ABDC File Offset: 0x00278DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277943, RefRangeEnd = 277944, XrefRangeStart = 277858, XrefRangeEnd = 277943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUIs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateUIs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x0027AC10 File Offset: 0x00278E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277944, XrefRangeEnd = 278012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x0027AC44 File Offset: 0x00278E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278089, RefRangeEnd = 278090, XrefRangeStart = 278012, XrefRangeEnd = 278089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C9E RID: 40094 RVA: 0x0027AC78 File Offset: 0x00278E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278090, XrefRangeEnd = 278101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToSelection(IConfigurable config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C9F RID: 40095 RVA: 0x0027ACBC File Offset: 0x00278EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278116, RefRangeEnd = 278117, XrefRangeStart = 278101, XrefRangeEnd = 278116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromSelection(IConfigurable config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CA0 RID: 40096 RVA: 0x0027AD00 File Offset: 0x00278F00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278136, RefRangeEnd = 278139, XrefRangeStart = 278117, XrefRangeEnd = 278136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_ClearSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CA1 RID: 40097 RVA: 0x0027AD34 File Offset: 0x00278F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278151, RefRangeEnd = 278153, XrefRangeStart = 278139, XrefRangeEnd = 278151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNullConfigurables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CA2 RID: 40098 RVA: 0x0027AD68 File Offset: 0x00278F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278153, XrefRangeEnd = 278162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IConfigurable GetHoveredConfigurable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr3) : null;
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x0027ADA8 File Offset: 0x00278FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278233, RefRangeEnd = 278234, XrefRangeStart = 278162, XrefRangeEnd = 278233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IConfigurable> GetConfigurablesToShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr3) : null;
		}

		// Token: 0x06009CA4 RID: 40100 RVA: 0x0027ADE8 File Offset: 0x00278FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278241, RefRangeEnd = 278242, XrefRangeStart = 278234, XrefRangeEnd = 278241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCrosshairPrompt(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CA5 RID: 40101 RVA: 0x0027AE2C File Offset: 0x0027902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278242, XrefRangeEnd = 278245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideCrosshairPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CA6 RID: 40102 RVA: 0x0027AE60 File Offset: 0x00279060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278245, XrefRangeEnd = 278260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementWorldspaceCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x0004CC53 File Offset: 0x0004AE53
		public ManagementWorldspaceCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x06009CA8 RID: 40104 RVA: 0x0027AE9C File Offset: 0x0027909C
		// (set) Token: 0x06009CA9 RID: 40105 RVA: 0x0004CC5C File Offset: 0x0004AE5C
		public unsafe static float VISIBILITY_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x06009CAA RID: 40106 RVA: 0x0027AEB8 File Offset: 0x002790B8
		// (set) Token: 0x06009CAB RID: 40107 RVA: 0x0004CC6A File Offset: 0x0004AE6A
		public unsafe static float PROPERTY_CANVAS_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x06009CAC RID: 40108 RVA: 0x0027AED4 File Offset: 0x002790D4
		// (set) Token: 0x06009CAD RID: 40109 RVA: 0x0004CC78 File Offset: 0x0004AE78
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x06009CAE RID: 40110 RVA: 0x0027AEFC File Offset: 0x002790FC
		// (set) Token: 0x06009CAF RID: 40111 RVA: 0x0004CC93 File Offset: 0x0004AE93
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x06009CB0 RID: 40112 RVA: 0x0027AF2C File Offset: 0x0027912C
		// (set) Token: 0x06009CB1 RID: 40113 RVA: 0x0004CCB2 File Offset: 0x0004AEB2
		public unsafe AnimationCurve ScaleCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x06009CB2 RID: 40114 RVA: 0x0027AF5C File Offset: 0x0027915C
		// (set) Token: 0x06009CB3 RID: 40115 RVA: 0x0004CCD1 File Offset: 0x0004AED1
		public unsafe TransitLineVisuals TransitRouteVisualsPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitLineVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x06009CB4 RID: 40116 RVA: 0x0027AF8C File Offset: 0x0027918C
		// (set) Token: 0x06009CB5 RID: 40117 RVA: 0x0004CCF0 File Offset: 0x0004AEF0
		public unsafe InputPrompt CrosshairPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_CrosshairPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x06009CB6 RID: 40118 RVA: 0x0027AFBC File Offset: 0x002791BC
		// (set) Token: 0x06009CB7 RID: 40119 RVA: 0x0004CD0F File Offset: 0x0004AF0F
		public unsafe LayerMask ObjectSelectionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask)) = value;
			}
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x06009CB8 RID: 40120 RVA: 0x0027AFE4 File Offset: 0x002791E4
		// (set) Token: 0x06009CB9 RID: 40121 RVA: 0x0004CD2A File Offset: 0x0004AF2A
		public unsafe Color HoveredOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor)) = value;
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x06009CBA RID: 40122 RVA: 0x0027B00C File Offset: 0x0027920C
		// (set) Token: 0x06009CBB RID: 40123 RVA: 0x0004CD45 File Offset: 0x0004AF45
		public unsafe Color SelectedOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor)) = value;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x06009CBC RID: 40124 RVA: 0x0027B034 File Offset: 0x00279234
		// (set) Token: 0x06009CBD RID: 40125 RVA: 0x0004CD60 File Offset: 0x0004AF60
		public unsafe List<IConfigurable> ShownConfigurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x06009CBE RID: 40126 RVA: 0x0027B064 File Offset: 0x00279264
		// (set) Token: 0x06009CBF RID: 40127 RVA: 0x0004CD7F File Offset: 0x0004AF7F
		public unsafe IConfigurable HoveredConfigurable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x0027B094 File Offset: 0x00279294
		// (set) Token: 0x06009CC1 RID: 40129 RVA: 0x0004CD9E File Offset: 0x0004AF9E
		public unsafe IConfigurable OutlinedConfigurable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x06009CC2 RID: 40130 RVA: 0x0027B0C4 File Offset: 0x002792C4
		// (set) Token: 0x06009CC3 RID: 40131 RVA: 0x0004CDBD File Offset: 0x0004AFBD
		public unsafe List<IConfigurable> SelectedConfigurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400692B RID: 26923
		private static readonly IntPtr NativeFieldInfoPtr_VISIBILITY_RANGE;

		// Token: 0x0400692C RID: 26924
		private static readonly IntPtr NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE;

		// Token: 0x0400692D RID: 26925
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400692E RID: 26926
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400692F RID: 26927
		private static readonly IntPtr NativeFieldInfoPtr_ScaleCurve;

		// Token: 0x04006930 RID: 26928
		private static readonly IntPtr NativeFieldInfoPtr_TransitRouteVisualsPrefab;

		// Token: 0x04006931 RID: 26929
		private static readonly IntPtr NativeFieldInfoPtr_CrosshairPrompt;

		// Token: 0x04006932 RID: 26930
		private static readonly IntPtr NativeFieldInfoPtr_ObjectSelectionLayerMask;

		// Token: 0x04006933 RID: 26931
		private static readonly IntPtr NativeFieldInfoPtr_HoveredOutlineColor;

		// Token: 0x04006934 RID: 26932
		private static readonly IntPtr NativeFieldInfoPtr_SelectedOutlineColor;

		// Token: 0x04006935 RID: 26933
		private static readonly IntPtr NativeFieldInfoPtr_ShownConfigurables;

		// Token: 0x04006936 RID: 26934
		private static readonly IntPtr NativeFieldInfoPtr_HoveredConfigurable;

		// Token: 0x04006937 RID: 26935
		private static readonly IntPtr NativeFieldInfoPtr_OutlinedConfigurable;

		// Token: 0x04006938 RID: 26936
		private static readonly IntPtr NativeFieldInfoPtr_SelectedConfigurables;

		// Token: 0x04006939 RID: 26937
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400693A RID: 26938
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400693B RID: 26939
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x0400693C RID: 26940
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400693D RID: 26941
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x0400693E RID: 26942
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400693F RID: 26943
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0;

		// Token: 0x04006940 RID: 26944
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUIs_Private_Void_0;

		// Token: 0x04006941 RID: 26945
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006942 RID: 26946
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04006943 RID: 26947
		private static readonly IntPtr NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0;

		// Token: 0x04006944 RID: 26948
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0;

		// Token: 0x04006945 RID: 26949
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Private_Void_0;

		// Token: 0x04006946 RID: 26950
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0;

		// Token: 0x04006947 RID: 26951
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0;

		// Token: 0x04006948 RID: 26952
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0;

		// Token: 0x04006949 RID: 26953
		private static readonly IntPtr NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0;

		// Token: 0x0400694A RID: 26954
		private static readonly IntPtr NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0;

		// Token: 0x0400694B RID: 26955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B92 RID: 2962
		[ObfuscatedName("ScheduleOne.UI.Management.ManagementWorldspaceCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DC07 RID: 56327 RVA: 0x00340AC4 File Offset: 0x0033ECC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr);
				ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, "<>9");
				ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, "<>9__24_0");
				ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, 100682540);
				ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, 100682541);
			}

			// Token: 0x0600DC08 RID: 56328 RVA: 0x00340B40 File Offset: 0x0033ED40
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC09 RID: 56329 RVA: 0x00340B7C File Offset: 0x0033ED7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277704, XrefRangeEnd = 277733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LateUpdate_b__24_0(IConfigurable a, IConfigurable b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC0A RID: 56330 RVA: 0x0006B317 File Offset: 0x00069517
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004436 RID: 17462
			// (get) Token: 0x0600DC0B RID: 56331 RVA: 0x00340BDC File Offset: 0x0033EDDC
			// (set) Token: 0x0600DC0C RID: 56332 RVA: 0x0006B320 File Offset: 0x00069520
			public unsafe static ManagementWorldspaceCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementWorldspaceCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004437 RID: 17463
			// (get) Token: 0x0600DC0D RID: 56333 RVA: 0x00340C04 File Offset: 0x0033EE04
			// (set) Token: 0x0600DC0E RID: 56334 RVA: 0x0006B332 File Offset: 0x00069532
			public unsafe static Comparison<IConfigurable> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<IConfigurable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400937E RID: 37758
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400937F RID: 37759
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04009380 RID: 37760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009381 RID: 37761
			private static readonly IntPtr NativeMethodInfoPtr__LateUpdate_b__24_0_Internal_Int32_IConfigurable_IConfigurable_0;
		}

		// Token: 0x02000B93 RID: 2963
		[ObfuscatedName("ScheduleOne.UI.Management.ManagementWorldspaceCanvas+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC0F RID: 56335 RVA: 0x00340C2C File Offset: 0x0033EE2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr);
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, "config");
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, 100682542);
				ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr, 100682543);
			}

			// Token: 0x0600DC10 RID: 56336 RVA: 0x00340CA8 File Offset: 0x0033EEA8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC11 RID: 56337 RVA: 0x00340CE4 File Offset: 0x0033EEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277733, XrefRangeEnd = 277737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateUIs_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC12 RID: 56338 RVA: 0x0006B344 File Offset: 0x00069544
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004438 RID: 17464
			// (get) Token: 0x0600DC13 RID: 56339 RVA: 0x00340D18 File Offset: 0x0033EF18
			// (set) Token: 0x0600DC14 RID: 56340 RVA: 0x0006B34D File Offset: 0x0006954D
			public unsafe IConfigurable config
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004439 RID: 17465
			// (get) Token: 0x0600DC15 RID: 56341 RVA: 0x00340D48 File Offset: 0x0033EF48
			// (set) Token: 0x0600DC16 RID: 56342 RVA: 0x0006B36C File Offset: 0x0006956C
			public unsafe ManagementWorldspaceCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementWorldspaceCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009382 RID: 37762
			private static readonly IntPtr NativeFieldInfoPtr_config;

			// Token: 0x04009383 RID: 37763
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009384 RID: 37764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009385 RID: 37765
			private static readonly IntPtr NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0;
		}
	}
}
