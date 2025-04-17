using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051B RID: 1307
	public class TrashBag_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007451 RID: 29777 RVA: 0x001FB14C File Offset: 0x001F934C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBag_Equippable()
		{
			Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashBag_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr);
			TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "TRASH_CONTAINER_INTERACT_DISTANCE");
			TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "BAG_TRASH_TIME");
			TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PICKUP_RANGE");
			TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PICKUP_AREA_RADIUS");
			TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "<IsBaggingTrash>k__BackingField");
			TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "<IsPickingUpTrash>k__BackingField");
			TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PickupLookMask");
			TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PickupAreaProjector");
			TrashBag_Equippable.NativeFieldInfoPtr_RustleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "RustleSound");
			TrashBag_Equippable.NativeFieldInfoPtr_BagSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "BagSound");
			TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_bagTrashTime");
			TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_baggedContainer");
			TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_pickupTrashTime");
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677919);
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677920);
			TrashBag_Equippable.NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677921);
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677922);
			TrashBag_Equippable.NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677923);
			TrashBag_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677924);
			TrashBag_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677925);
			TrashBag_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677926);
			TrashBag_Equippable.NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677927);
			TrashBag_Equippable.NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677928);
			TrashBag_Equippable.NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677929);
			TrashBag_Equippable.NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677930);
			TrashBag_Equippable.NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677931);
			TrashBag_Equippable.NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677932);
			TrashBag_Equippable.NativeMethodInfoPtr_StartPickup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677933);
			TrashBag_Equippable.NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677934);
			TrashBag_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677935);
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06007452 RID: 29778 RVA: 0x001FB3D4 File Offset: 0x001F95D4
		public unsafe static bool IsHoveringTrash
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227310, RefRangeEnd = 227311, XrefRangeStart = 227303, XrefRangeEnd = 227310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06007453 RID: 29779 RVA: 0x001FB404 File Offset: 0x001F9604
		// (set) Token: 0x06007454 RID: 29780 RVA: 0x001FB440 File Offset: 0x001F9640
		public unsafe bool IsBaggingTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x06007455 RID: 29781 RVA: 0x001FB480 File Offset: 0x001F9680
		// (set) Token: 0x06007456 RID: 29782 RVA: 0x001FB4BC File Offset: 0x001F96BC
		public unsafe bool IsPickingUpTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x001FB4FC File Offset: 0x001F96FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227311, XrefRangeEnd = 227339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007458 RID: 29784 RVA: 0x001FB54C File Offset: 0x001F974C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227339, XrefRangeEnd = 227351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007459 RID: 29785 RVA: 0x001FB588 File Offset: 0x001F9788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227351, XrefRangeEnd = 227446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x001FB5C4 File Offset: 0x001F97C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227463, RefRangeEnd = 227464, XrefRangeStart = 227446, XrefRangeEnd = 227463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainer GetHoveredTrashContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr3) : null;
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x001FB604 File Offset: 0x001F9804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227469, RefRangeEnd = 227471, XrefRangeStart = 227464, XrefRangeEnd = 227469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaycastLook(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x001FB650 File Offset: 0x001F9850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227475, RefRangeEnd = 227477, XrefRangeStart = 227471, XrefRangeEnd = 227475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPickupLocationValid(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x001FB69C File Offset: 0x001F989C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227503, RefRangeEnd = 227506, XrefRangeStart = 227477, XrefRangeEnd = 227503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TrashItem> GetTrashItemsAtPoint(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x001FB6E8 File Offset: 0x001F98E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227506, XrefRangeEnd = 227508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBagTrash(TrashContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x001FB72C File Offset: 0x001F992C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227508, XrefRangeEnd = 227513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBagTrash(bool complete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x001FB76C File Offset: 0x001F996C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227513, XrefRangeEnd = 227514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StartPickup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x001FB7A0 File Offset: 0x001F99A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227560, RefRangeEnd = 227561, XrefRangeStart = 227514, XrefRangeEnd = 227560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPickup(bool complete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x001FB7E0 File Offset: 0x001F99E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBag_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007463 RID: 29795 RVA: 0x000373F3 File Offset: 0x000355F3
		public TrashBag_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x06007464 RID: 29796 RVA: 0x001FB81C File Offset: 0x001F9A1C
		// (set) Token: 0x06007465 RID: 29797 RVA: 0x000373FC File Offset: 0x000355FC
		public unsafe static float TRASH_CONTAINER_INTERACT_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x06007466 RID: 29798 RVA: 0x001FB838 File Offset: 0x001F9A38
		// (set) Token: 0x06007467 RID: 29799 RVA: 0x0003740A File Offset: 0x0003560A
		public unsafe static float BAG_TRASH_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x06007468 RID: 29800 RVA: 0x001FB854 File Offset: 0x001F9A54
		// (set) Token: 0x06007469 RID: 29801 RVA: 0x00037418 File Offset: 0x00035618
		public unsafe static float PICKUP_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x0600746A RID: 29802 RVA: 0x001FB870 File Offset: 0x001F9A70
		// (set) Token: 0x0600746B RID: 29803 RVA: 0x00037426 File Offset: 0x00035626
		public unsafe static float PICKUP_AREA_RADIUS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS, (void*)(&value));
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x0600746C RID: 29804 RVA: 0x001FB88C File Offset: 0x001F9A8C
		// (set) Token: 0x0600746D RID: 29805 RVA: 0x00037434 File Offset: 0x00035634
		public unsafe bool _IsBaggingTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField)) = value;
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x0600746E RID: 29806 RVA: 0x001FB8B4 File Offset: 0x001F9AB4
		// (set) Token: 0x0600746F RID: 29807 RVA: 0x0003744F File Offset: 0x0003564F
		public unsafe bool _IsPickingUpTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField)) = value;
			}
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06007470 RID: 29808 RVA: 0x001FB8DC File Offset: 0x001F9ADC
		// (set) Token: 0x06007471 RID: 29809 RVA: 0x0003746A File Offset: 0x0003566A
		public unsafe LayerMask PickupLookMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask)) = value;
			}
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x06007472 RID: 29810 RVA: 0x001FB904 File Offset: 0x001F9B04
		// (set) Token: 0x06007473 RID: 29811 RVA: 0x00037485 File Offset: 0x00035685
		public unsafe DecalProjector PickupAreaProjector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x06007474 RID: 29812 RVA: 0x001FB934 File Offset: 0x001F9B34
		// (set) Token: 0x06007475 RID: 29813 RVA: 0x000374A4 File Offset: 0x000356A4
		public unsafe AudioSourceController RustleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_RustleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_RustleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x001FB964 File Offset: 0x001F9B64
		// (set) Token: 0x06007477 RID: 29815 RVA: 0x000374C3 File Offset: 0x000356C3
		public unsafe AudioSourceController BagSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_BagSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_BagSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x06007478 RID: 29816 RVA: 0x001FB994 File Offset: 0x001F9B94
		// (set) Token: 0x06007479 RID: 29817 RVA: 0x000374E2 File Offset: 0x000356E2
		public unsafe float _bagTrashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime)) = value;
			}
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x0600747A RID: 29818 RVA: 0x001FB9BC File Offset: 0x001F9BBC
		// (set) Token: 0x0600747B RID: 29819 RVA: 0x000374FD File Offset: 0x000356FD
		public unsafe TrashContainer _baggedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x0600747C RID: 29820 RVA: 0x001FB9EC File Offset: 0x001F9BEC
		// (set) Token: 0x0600747D RID: 29821 RVA: 0x0003751C File Offset: 0x0003571C
		public unsafe float _pickupTrashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime)) = value;
			}
		}

		// Token: 0x04004F6B RID: 20331
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE;

		// Token: 0x04004F6C RID: 20332
		private static readonly IntPtr NativeFieldInfoPtr_BAG_TRASH_TIME;

		// Token: 0x04004F6D RID: 20333
		private static readonly IntPtr NativeFieldInfoPtr_PICKUP_RANGE;

		// Token: 0x04004F6E RID: 20334
		private static readonly IntPtr NativeFieldInfoPtr_PICKUP_AREA_RADIUS;

		// Token: 0x04004F6F RID: 20335
		private static readonly IntPtr NativeFieldInfoPtr__IsBaggingTrash_k__BackingField;

		// Token: 0x04004F70 RID: 20336
		private static readonly IntPtr NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField;

		// Token: 0x04004F71 RID: 20337
		private static readonly IntPtr NativeFieldInfoPtr_PickupLookMask;

		// Token: 0x04004F72 RID: 20338
		private static readonly IntPtr NativeFieldInfoPtr_PickupAreaProjector;

		// Token: 0x04004F73 RID: 20339
		private static readonly IntPtr NativeFieldInfoPtr_RustleSound;

		// Token: 0x04004F74 RID: 20340
		private static readonly IntPtr NativeFieldInfoPtr_BagSound;

		// Token: 0x04004F75 RID: 20341
		private static readonly IntPtr NativeFieldInfoPtr__bagTrashTime;

		// Token: 0x04004F76 RID: 20342
		private static readonly IntPtr NativeFieldInfoPtr__baggedContainer;

		// Token: 0x04004F77 RID: 20343
		private static readonly IntPtr NativeFieldInfoPtr__pickupTrashTime;

		// Token: 0x04004F78 RID: 20344
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0;

		// Token: 0x04004F79 RID: 20345
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0;

		// Token: 0x04004F7A RID: 20346
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0;

		// Token: 0x04004F7B RID: 20347
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0;

		// Token: 0x04004F7C RID: 20348
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0;

		// Token: 0x04004F7D RID: 20349
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04004F7E RID: 20350
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04004F7F RID: 20351
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004F80 RID: 20352
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0;

		// Token: 0x04004F81 RID: 20353
		private static readonly IntPtr NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0;

		// Token: 0x04004F82 RID: 20354
		private static readonly IntPtr NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0;

		// Token: 0x04004F83 RID: 20355
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0;

		// Token: 0x04004F84 RID: 20356
		private static readonly IntPtr NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0;

		// Token: 0x04004F85 RID: 20357
		private static readonly IntPtr NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0;

		// Token: 0x04004F86 RID: 20358
		private static readonly IntPtr NativeMethodInfoPtr_StartPickup_Private_Void_0;

		// Token: 0x04004F87 RID: 20359
		private static readonly IntPtr NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0;

		// Token: 0x04004F88 RID: 20360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
