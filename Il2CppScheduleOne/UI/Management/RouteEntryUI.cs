using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CB RID: 1739
	public class RouteEntryUI : MonoBehaviour
	{
		// Token: 0x06009C2C RID: 39980 RVA: 0x00279298 File Offset: 0x00277498
		// Note: this type is marked as 'beforefieldinit'.
		static RouteEntryUI()
		{
			Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RouteEntryUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr);
			RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "<AssignedRoute>k__BackingField");
			RouteEntryUI.NativeFieldInfoPtr_SourceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "SourceLabel");
			RouteEntryUI.NativeFieldInfoPtr_DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "DestinationLabel");
			RouteEntryUI.NativeFieldInfoPtr_FilterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "FilterIcon");
			RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "onDeleteClicked");
			RouteEntryUI.NativeFieldInfoPtr_settingSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "settingSource");
			RouteEntryUI.NativeFieldInfoPtr_settingDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "settingDestination");
			RouteEntryUI.NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682471);
			RouteEntryUI.NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682472);
			RouteEntryUI.NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682473);
			RouteEntryUI.NativeMethodInfoPtr_ClearRoute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682474);
			RouteEntryUI.NativeMethodInfoPtr_RefreshUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682475);
			RouteEntryUI.NativeMethodInfoPtr_SourceClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682476);
			RouteEntryUI.NativeMethodInfoPtr_DestinationClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682477);
			RouteEntryUI.NativeMethodInfoPtr_FilterClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682478);
			RouteEntryUI.NativeMethodInfoPtr_DeleteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682479);
			RouteEntryUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682480);
			RouteEntryUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682481);
			RouteEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682482);
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x06009C2D RID: 39981 RVA: 0x00279444 File Offset: 0x00277644
		// (set) Token: 0x06009C2E RID: 39982 RVA: 0x00279484 File Offset: 0x00277684
		public unsafe AdvancedTransitRoute AssignedRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C2F RID: 39983 RVA: 0x002794C8 File Offset: 0x002776C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277013, RefRangeEnd = 277014, XrefRangeStart = 277002, XrefRangeEnd = 277013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRoute(AdvancedTransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C30 RID: 39984 RVA: 0x0027950C File Offset: 0x0027770C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRoute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ClearRoute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C31 RID: 39985 RVA: 0x00279540 File Offset: 0x00277740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277014, XrefRangeEnd = 277024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_RefreshUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C32 RID: 39986 RVA: 0x00279574 File Offset: 0x00277774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277024, XrefRangeEnd = 277068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SourceClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_SourceClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C33 RID: 39987 RVA: 0x002795A8 File Offset: 0x002777A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277068, XrefRangeEnd = 277112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_DestinationClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C34 RID: 39988 RVA: 0x002795DC File Offset: 0x002777DC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_FilterClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C35 RID: 39989 RVA: 0x00279610 File Offset: 0x00277810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277112, XrefRangeEnd = 277113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_DeleteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C36 RID: 39990 RVA: 0x00279644 File Offset: 0x00277844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277113, XrefRangeEnd = 277121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(ITransitEntity obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x002796AC File Offset: 0x002778AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277121, XrefRangeEnd = 277131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<ITransitEntity> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x002796F0 File Offset: 0x002778F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277131, XrefRangeEnd = 277137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteEntryUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x0004C8D3 File Offset: 0x0004AAD3
		public RouteEntryUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x0027972C File Offset: 0x0027792C
		// (set) Token: 0x06009C3B RID: 39995 RVA: 0x0004C8DC File Offset: 0x0004AADC
		public unsafe AdvancedTransitRoute _AssignedRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x06009C3C RID: 39996 RVA: 0x0027975C File Offset: 0x0027795C
		// (set) Token: 0x06009C3D RID: 39997 RVA: 0x0004C8FB File Offset: 0x0004AAFB
		public unsafe TextMeshProUGUI SourceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x06009C3E RID: 39998 RVA: 0x0027978C File Offset: 0x0027798C
		// (set) Token: 0x06009C3F RID: 39999 RVA: 0x0004C91A File Offset: 0x0004AB1A
		public unsafe TextMeshProUGUI DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x06009C40 RID: 40000 RVA: 0x002797BC File Offset: 0x002779BC
		// (set) Token: 0x06009C41 RID: 40001 RVA: 0x0004C939 File Offset: 0x0004AB39
		public unsafe Image FilterIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_FilterIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_FilterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x06009C42 RID: 40002 RVA: 0x002797EC File Offset: 0x002779EC
		// (set) Token: 0x06009C43 RID: 40003 RVA: 0x0004C958 File Offset: 0x0004AB58
		public unsafe UnityEvent onDeleteClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x06009C44 RID: 40004 RVA: 0x0027981C File Offset: 0x00277A1C
		// (set) Token: 0x06009C45 RID: 40005 RVA: 0x0004C977 File Offset: 0x0004AB77
		public unsafe bool settingSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingSource)) = value;
			}
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x06009C46 RID: 40006 RVA: 0x00279844 File Offset: 0x00277A44
		// (set) Token: 0x06009C47 RID: 40007 RVA: 0x0004C992 File Offset: 0x0004AB92
		public unsafe bool settingDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingDestination)) = value;
			}
		}

		// Token: 0x040068E8 RID: 26856
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRoute_k__BackingField;

		// Token: 0x040068E9 RID: 26857
		private static readonly IntPtr NativeFieldInfoPtr_SourceLabel;

		// Token: 0x040068EA RID: 26858
		private static readonly IntPtr NativeFieldInfoPtr_DestinationLabel;

		// Token: 0x040068EB RID: 26859
		private static readonly IntPtr NativeFieldInfoPtr_FilterIcon;

		// Token: 0x040068EC RID: 26860
		private static readonly IntPtr NativeFieldInfoPtr_onDeleteClicked;

		// Token: 0x040068ED RID: 26861
		private static readonly IntPtr NativeFieldInfoPtr_settingSource;

		// Token: 0x040068EE RID: 26862
		private static readonly IntPtr NativeFieldInfoPtr_settingDestination;

		// Token: 0x040068EF RID: 26863
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0;

		// Token: 0x040068F0 RID: 26864
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0;

		// Token: 0x040068F1 RID: 26865
		private static readonly IntPtr NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040068F2 RID: 26866
		private static readonly IntPtr NativeMethodInfoPtr_ClearRoute_Public_Void_0;

		// Token: 0x040068F3 RID: 26867
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Public_Void_0;

		// Token: 0x040068F4 RID: 26868
		private static readonly IntPtr NativeMethodInfoPtr_SourceClicked_Public_Void_0;

		// Token: 0x040068F5 RID: 26869
		private static readonly IntPtr NativeMethodInfoPtr_DestinationClicked_Public_Void_0;

		// Token: 0x040068F6 RID: 26870
		private static readonly IntPtr NativeMethodInfoPtr_FilterClicked_Public_Void_0;

		// Token: 0x040068F7 RID: 26871
		private static readonly IntPtr NativeMethodInfoPtr_DeleteClicked_Public_Void_0;

		// Token: 0x040068F8 RID: 26872
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0;

		// Token: 0x040068F9 RID: 26873
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0;

		// Token: 0x040068FA RID: 26874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
