using System;
using Il2CppEPOOutline;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200047C RID: 1148
	public class LoadingDock : MonoBehaviour
	{
		// Token: 0x0600635D RID: 25437 RVA: 0x001C2CF0 File Offset: 0x001C0EF0
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingDock()
		{
			Il2CppClassPointerStore<LoadingDock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "LoadingDock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr);
			LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<DynamicOccupant>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<StaticOccupant>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<GUID>k__BackingField");
			LoadingDock.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "BakedGUID");
			LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<InputSlots>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<OutputSlots>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<Selectable>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<IsDestroyed>k__BackingField");
			LoadingDock.NativeFieldInfoPtr_ParentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "ParentProperty");
			LoadingDock.NativeFieldInfoPtr_VehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "VehicleDetector");
			LoadingDock.NativeFieldInfoPtr_Parking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "Parking");
			LoadingDock.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "uiPoint");
			LoadingDock.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "accessPoints");
			LoadingDock.NativeFieldInfoPtr_OutlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "OutlineRenderers");
			LoadingDock.NativeFieldInfoPtr_OutlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "OutlineEffect");
			LoadingDock.NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675901);
			LoadingDock.NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675902);
			LoadingDock.NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675903);
			LoadingDock.NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675904);
			LoadingDock.NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675905);
			LoadingDock.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675906);
			LoadingDock.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675907);
			LoadingDock.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675908);
			LoadingDock.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675909);
			LoadingDock.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675910);
			LoadingDock.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675911);
			LoadingDock.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675912);
			LoadingDock.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675913);
			LoadingDock.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675914);
			LoadingDock.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675915);
			LoadingDock.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675916);
			LoadingDock.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675917);
			LoadingDock.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675918);
			LoadingDock.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675919);
			LoadingDock.NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675920);
			LoadingDock.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675921);
			LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675922);
			LoadingDock.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675923);
			LoadingDock.NativeMethodInfoPtr_RefreshOccupant_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675924);
			LoadingDock.NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675925);
			LoadingDock.NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675926);
			LoadingDock.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675927);
			LoadingDock.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675928);
			LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675929);
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x0600635E RID: 25438 RVA: 0x001C30A4 File Offset: 0x001C12A4
		// (set) Token: 0x0600635F RID: 25439 RVA: 0x001C30E4 File Offset: 0x001C12E4
		public unsafe LandVehicle DynamicOccupant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06006360 RID: 25440 RVA: 0x001C3128 File Offset: 0x001C1328
		// (set) Token: 0x06006361 RID: 25441 RVA: 0x001C3168 File Offset: 0x001C1368
		public unsafe LandVehicle StaticOccupant
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06006362 RID: 25442 RVA: 0x001C31AC File Offset: 0x001C13AC
		public unsafe bool IsInUse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203323, XrefRangeEnd = 203327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06006363 RID: 25443 RVA: 0x001C31E8 File Offset: 0x001C13E8
		// (set) Token: 0x06006364 RID: 25444 RVA: 0x001C3224 File Offset: 0x001C1424
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x001C3264 File Offset: 0x001C1464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203327, XrefRangeEnd = 203330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06006366 RID: 25446 RVA: 0x001C3298 File Offset: 0x001C1498
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203330, XrefRangeEnd = 203337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06006367 RID: 25447 RVA: 0x001C32D0 File Offset: 0x001C14D0
		// (set) Token: 0x06006368 RID: 25448 RVA: 0x001C3310 File Offset: 0x001C1510
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06006369 RID: 25449 RVA: 0x001C3354 File Offset: 0x001C1554
		// (set) Token: 0x0600636A RID: 25450 RVA: 0x001C3394 File Offset: 0x001C1594
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x0600636B RID: 25451 RVA: 0x001C33D8 File Offset: 0x001C15D8
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45797, RefRangeEnd = 45798, XrefRangeStart = 45797, XrefRangeEnd = 45798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x0600636C RID: 25452 RVA: 0x001C3418 File Offset: 0x001C1618
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x0600636D RID: 25453 RVA: 0x001C3458 File Offset: 0x001C1658
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x0600636E RID: 25454 RVA: 0x001C3494 File Offset: 0x001C1694
		// (set) Token: 0x0600636F RID: 25455 RVA: 0x001C34D0 File Offset: 0x001C16D0
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06006370 RID: 25456 RVA: 0x001C3510 File Offset: 0x001C1710
		// (set) Token: 0x06006371 RID: 25457 RVA: 0x001C354C File Offset: 0x001C174C
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x001C358C File Offset: 0x001C178C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203337, XrefRangeEnd = 203342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x001C35C0 File Offset: 0x001C17C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203342, XrefRangeEnd = 203346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x001C35F4 File Offset: 0x001C17F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203346, XrefRangeEnd = 203350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x001C3634 File Offset: 0x001C1834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203350, XrefRangeEnd = 203383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshOccupant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_RefreshOccupant_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x001C3668 File Offset: 0x001C1868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203424, RefRangeEnd = 203425, XrefRangeStart = 203383, XrefRangeEnd = 203424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(LandVehicle occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x001C36AC File Offset: 0x001C18AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStaticOccupant(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x001C36F0 File Offset: 0x001C18F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203425, XrefRangeEnd = 203466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x001C373C File Offset: 0x001C193C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203466, XrefRangeEnd = 203471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x001C3778 File Offset: 0x001C1978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203471, XrefRangeEnd = 203487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingDock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x0002EF68 File Offset: 0x0002D168
		public LoadingDock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x0600637C RID: 25468 RVA: 0x001C37B4 File Offset: 0x001C19B4
		// (set) Token: 0x0600637D RID: 25469 RVA: 0x0002EF71 File Offset: 0x0002D171
		public unsafe LandVehicle _DynamicOccupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x0600637E RID: 25470 RVA: 0x001C37E4 File Offset: 0x001C19E4
		// (set) Token: 0x0600637F RID: 25471 RVA: 0x0002EF90 File Offset: 0x0002D190
		public unsafe LandVehicle _StaticOccupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x001C3814 File Offset: 0x001C1A14
		// (set) Token: 0x06006381 RID: 25473 RVA: 0x0002EFAF File Offset: 0x0002D1AF
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x001C383C File Offset: 0x001C1A3C
		// (set) Token: 0x06006383 RID: 25475 RVA: 0x0002EFCA File Offset: 0x0002D1CA
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x001C3864 File Offset: 0x001C1A64
		// (set) Token: 0x06006385 RID: 25477 RVA: 0x0002EFE9 File Offset: 0x0002D1E9
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06006386 RID: 25478 RVA: 0x001C3894 File Offset: 0x001C1A94
		// (set) Token: 0x06006387 RID: 25479 RVA: 0x0002F008 File Offset: 0x0002D208
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06006388 RID: 25480 RVA: 0x001C38C4 File Offset: 0x001C1AC4
		// (set) Token: 0x06006389 RID: 25481 RVA: 0x0002F027 File Offset: 0x0002D227
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x0600638A RID: 25482 RVA: 0x001C38EC File Offset: 0x001C1AEC
		// (set) Token: 0x0600638B RID: 25483 RVA: 0x0002F042 File Offset: 0x0002D242
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x0600638C RID: 25484 RVA: 0x001C3914 File Offset: 0x001C1B14
		// (set) Token: 0x0600638D RID: 25485 RVA: 0x0002F05D File Offset: 0x0002D25D
		public unsafe bool _IsDestroyed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x0600638E RID: 25486 RVA: 0x001C393C File Offset: 0x001C1B3C
		// (set) Token: 0x0600638F RID: 25487 RVA: 0x0002F078 File Offset: 0x0002D278
		public unsafe Property ParentProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_ParentProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_ParentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06006390 RID: 25488 RVA: 0x001C396C File Offset: 0x001C1B6C
		// (set) Token: 0x06006391 RID: 25489 RVA: 0x0002F097 File Offset: 0x0002D297
		public unsafe VehicleDetector VehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_VehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_VehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06006392 RID: 25490 RVA: 0x001C399C File Offset: 0x001C1B9C
		// (set) Token: 0x06006393 RID: 25491 RVA: 0x0002F0B6 File Offset: 0x0002D2B6
		public unsafe ParkingLot Parking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_Parking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_Parking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x001C39CC File Offset: 0x001C1BCC
		// (set) Token: 0x06006395 RID: 25493 RVA: 0x0002F0D5 File Offset: 0x0002D2D5
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06006396 RID: 25494 RVA: 0x001C39FC File Offset: 0x001C1BFC
		// (set) Token: 0x06006397 RID: 25495 RVA: 0x0002F0F4 File Offset: 0x0002D2F4
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06006398 RID: 25496 RVA: 0x001C3A2C File Offset: 0x001C1C2C
		// (set) Token: 0x06006399 RID: 25497 RVA: 0x0002F113 File Offset: 0x0002D313
		public unsafe Il2CppReferenceArray<GameObject> OutlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x0600639A RID: 25498 RVA: 0x001C3A5C File Offset: 0x001C1C5C
		// (set) Token: 0x0600639B RID: 25499 RVA: 0x0002F132 File Offset: 0x0002D332
		public unsafe Outlinable OutlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043D1 RID: 17361
		private static readonly IntPtr NativeFieldInfoPtr__DynamicOccupant_k__BackingField;

		// Token: 0x040043D2 RID: 17362
		private static readonly IntPtr NativeFieldInfoPtr__StaticOccupant_k__BackingField;

		// Token: 0x040043D3 RID: 17363
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x040043D4 RID: 17364
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x040043D5 RID: 17365
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x040043D6 RID: 17366
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x040043D7 RID: 17367
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x040043D8 RID: 17368
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x040043D9 RID: 17369
		private static readonly IntPtr NativeFieldInfoPtr__IsDestroyed_k__BackingField;

		// Token: 0x040043DA RID: 17370
		private static readonly IntPtr NativeFieldInfoPtr_ParentProperty;

		// Token: 0x040043DB RID: 17371
		private static readonly IntPtr NativeFieldInfoPtr_VehicleDetector;

		// Token: 0x040043DC RID: 17372
		private static readonly IntPtr NativeFieldInfoPtr_Parking;

		// Token: 0x040043DD RID: 17373
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x040043DE RID: 17374
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x040043DF RID: 17375
		private static readonly IntPtr NativeFieldInfoPtr_OutlineRenderers;

		// Token: 0x040043E0 RID: 17376
		private static readonly IntPtr NativeFieldInfoPtr_OutlineEffect;

		// Token: 0x040043E1 RID: 17377
		private static readonly IntPtr NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0;

		// Token: 0x040043E2 RID: 17378
		private static readonly IntPtr NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0;

		// Token: 0x040043E3 RID: 17379
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0;

		// Token: 0x040043E4 RID: 17380
		private static readonly IntPtr NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0;

		// Token: 0x040043E5 RID: 17381
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0;

		// Token: 0x040043E6 RID: 17382
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x040043E7 RID: 17383
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040043E8 RID: 17384
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x040043E9 RID: 17385
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040043EA RID: 17386
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040043EB RID: 17387
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040043EC RID: 17388
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040043ED RID: 17389
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040043EE RID: 17390
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040043EF RID: 17391
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x040043F0 RID: 17392
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040043F1 RID: 17393
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040043F2 RID: 17394
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x040043F3 RID: 17395
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040043F4 RID: 17396
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0;

		// Token: 0x040043F5 RID: 17397
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040043F6 RID: 17398
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040043F7 RID: 17399
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040043F8 RID: 17400
		private static readonly IntPtr NativeMethodInfoPtr_RefreshOccupant_Private_Void_0;

		// Token: 0x040043F9 RID: 17401
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0;

		// Token: 0x040043FA RID: 17402
		private static readonly IntPtr NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0;

		// Token: 0x040043FB RID: 17403
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0;

		// Token: 0x040043FC RID: 17404
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0;

		// Token: 0x040043FD RID: 17405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
