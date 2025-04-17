using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200034C RID: 844
	public class MoveItemBehaviour : Behaviour
	{
		// Token: 0x06003F8C RID: 16268 RVA: 0x001409D4 File Offset: 0x0013EBD4
		// Note: this type is marked as 'beforefieldinit'.
		static MoveItemBehaviour()
		{
			Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "MoveItemBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr);
			MoveItemBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<Initialized>k__BackingField");
			MoveItemBehaviour.NativeFieldInfoPtr_assignedRoute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "assignedRoute");
			MoveItemBehaviour.NativeFieldInfoPtr_itemToRetrieveTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "itemToRetrieveTemplate");
			MoveItemBehaviour.NativeFieldInfoPtr_grabbedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "grabbedAmount");
			MoveItemBehaviour.NativeFieldInfoPtr_maxMoveAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "maxMoveAmount");
			MoveItemBehaviour.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "currentState");
			MoveItemBehaviour.NativeFieldInfoPtr_walkToSourceRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "walkToSourceRoutine");
			MoveItemBehaviour.NativeFieldInfoPtr_grabRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "grabRoutine");
			MoveItemBehaviour.NativeFieldInfoPtr_walkToDestinationRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "walkToDestinationRoutine");
			MoveItemBehaviour.NativeFieldInfoPtr_placingRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "placingRoutine");
			MoveItemBehaviour.NativeFieldInfoPtr_skipPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "skipPickup");
			MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted");
			MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted");
			MoveItemBehaviour.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670857);
			MoveItemBehaviour.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670858);
			MoveItemBehaviour.NativeMethodInfoPtr_Initialize_Public_Void_TransitRoute_ItemInstance_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670859);
			MoveItemBehaviour.NativeMethodInfoPtr_Resume_Public_Void_TransitRoute_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670860);
			MoveItemBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670861);
			MoveItemBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670862);
			MoveItemBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670863);
			MoveItemBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670864);
			MoveItemBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670865);
			MoveItemBehaviour.NativeMethodInfoPtr_StartTransit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670866);
			MoveItemBehaviour.NativeMethodInfoPtr_IsNpcInventoryItemValid_Private_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670867);
			MoveItemBehaviour.NativeMethodInfoPtr_EndTransit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670868);
			MoveItemBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670869);
			MoveItemBehaviour.NativeMethodInfoPtr_WalkToSource_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670870);
			MoveItemBehaviour.NativeMethodInfoPtr_GrabItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670871);
			MoveItemBehaviour.NativeMethodInfoPtr_TakeItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670872);
			MoveItemBehaviour.NativeMethodInfoPtr_WalkToDestination_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670873);
			MoveItemBehaviour.NativeMethodInfoPtr_PlaceItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670874);
			MoveItemBehaviour.NativeMethodInfoPtr_GetAmountToGrab_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670875);
			MoveItemBehaviour.NativeMethodInfoPtr_StopCurrentActivity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670876);
			MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670877);
			MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_ItemInstance_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670878);
			MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670879);
			MoveItemBehaviour.NativeMethodInfoPtr_IsDestinationValid_Public_Boolean_TransitRoute_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670880);
			MoveItemBehaviour.NativeMethodInfoPtr_CanGetToSource_Public_Boolean_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670881);
			MoveItemBehaviour.NativeMethodInfoPtr_GetSourceAccessPoint_Private_Transform_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670882);
			MoveItemBehaviour.NativeMethodInfoPtr_IsAtSource_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670883);
			MoveItemBehaviour.NativeMethodInfoPtr_CanGetToDestination_Public_Boolean_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670884);
			MoveItemBehaviour.NativeMethodInfoPtr_GetDestinationAccessPoint_Private_Transform_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670885);
			MoveItemBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670886);
			MoveItemBehaviour.NativeMethodInfoPtr_GetSaveData_Public_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670887);
			MoveItemBehaviour.NativeMethodInfoPtr_Load_Public_Void_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670888);
			MoveItemBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670889);
			MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670890);
			MoveItemBehaviour.NativeMethodInfoPtr__WalkToSource_b__26_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670891);
			MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670892);
			MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670893);
			MoveItemBehaviour.NativeMethodInfoPtr__WalkToDestination_b__29_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670894);
			MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670895);
			MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670896);
			MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670897);
			MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670898);
			MoveItemBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, 100670899);
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x00140E64 File Offset: 0x0013F064
		// (set) Token: 0x06003F8E RID: 16270 RVA: 0x00140EA0 File Offset: 0x0013F0A0
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00140EE0 File Offset: 0x0013F0E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 148239, RefRangeEnd = 148243, XrefRangeStart = 148203, XrefRangeEnd = 148239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1, bool _skipPickup = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemToRetrieveTemplate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxMoveAmount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _skipPickup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Initialize_Public_Void_TransitRoute_ItemInstance_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x00140F50 File Offset: 0x0013F150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148243, XrefRangeEnd = 148245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemToRetrieveTemplate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxMoveAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Resume_Public_Void_TransitRoute_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00140FB4 File Offset: 0x0013F1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148245, XrefRangeEnd = 148247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00140FF0 File Offset: 0x0013F1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148247, XrefRangeEnd = 148249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0014102C File Offset: 0x0013F22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148249, XrefRangeEnd = 148251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x00141068 File Offset: 0x0013F268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148251, XrefRangeEnd = 148264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x001410A4 File Offset: 0x0013F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x001410E0 File Offset: 0x0013F2E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148291, RefRangeEnd = 148293, XrefRangeStart = 148264, XrefRangeEnd = 148291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTransit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_StartTransit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00141114 File Offset: 0x0013F314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148293, XrefRangeEnd = 148297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNpcInventoryItemValid(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsNpcInventoryItemValid_Private_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00141164 File Offset: 0x0013F364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148297, XrefRangeEnd = 148309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndTransit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_EndTransit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00141198 File Offset: 0x0013F398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148309, XrefRangeEnd = 148354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x001411D4 File Offset: 0x0013F3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148354, XrefRangeEnd = 148382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkToSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_WalkToSource_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00141208 File Offset: 0x0013F408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148382, XrefRangeEnd = 148396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GrabItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x0014123C File Offset: 0x0013F43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148418, RefRangeEnd = 148419, XrefRangeStart = 148396, XrefRangeEnd = 148418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_TakeItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00141270 File Offset: 0x0013F470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148419, XrefRangeEnd = 148443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkToDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_WalkToDestination_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x001412A4 File Offset: 0x0013F4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148443, XrefRangeEnd = 148457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_PlaceItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x001412D8 File Offset: 0x0013F4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148457, XrefRangeEnd = 148463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAmountToGrab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GetAmountToGrab_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00141314 File Offset: 0x0013F514
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 148467, RefRangeEnd = 148470, XrefRangeStart = 148463, XrefRangeEnd = 148467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCurrentActivity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_StopCurrentActivity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00141348 File Offset: 0x0013F548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148487, RefRangeEnd = 148488, XrefRangeStart = 148470, XrefRangeEnd = 148487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTransitRouteValid(TransitRoute route, string itemID, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(itemID);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x001413C4 File Offset: 0x0013F5C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148513, RefRangeEnd = 148515, XrefRangeStart = 148488, XrefRangeEnd = 148513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTransitRouteValid(TransitRoute route, ItemInstance templateItem, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(templateItem);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_ItemInstance_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00141440 File Offset: 0x0013F640
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 148516, RefRangeEnd = 148523, XrefRangeStart = 148515, XrefRangeEnd = 148516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTransitRouteValid(TransitRoute route, string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x001414A0 File Offset: 0x0013F6A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 148550, RefRangeEnd = 148553, XrefRangeStart = 148523, XrefRangeEnd = 148550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDestinationValid(TransitRoute route, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsDestinationValid_Public_Boolean_TransitRoute_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00141500 File Offset: 0x0013F700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148553, XrefRangeEnd = 148563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetToSource(TransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_CanGetToSource_Public_Boolean_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00141550 File Offset: 0x0013F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148563, XrefRangeEnd = 148569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetSourceAccessPoint(TransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GetSourceAccessPoint_Private_Transform_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x001415A0 File Offset: 0x0013F7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148569, XrefRangeEnd = 148575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsAtSource_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x001415DC File Offset: 0x0013F7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148575, XrefRangeEnd = 148580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetToDestination(TransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_CanGetToDestination_Public_Boolean_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x0014162C File Offset: 0x0013F82C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 148591, RefRangeEnd = 148595, XrefRangeStart = 148580, XrefRangeEnd = 148591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetDestinationAccessPoint(TransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GetDestinationAccessPoint_Private_Transform_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x0014167C File Offset: 0x0013F87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148623, RefRangeEnd = 148624, XrefRangeStart = 148595, XrefRangeEnd = 148623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x001416B8 File Offset: 0x0013F8B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 148643, RefRangeEnd = 148647, XrefRangeStart = 148624, XrefRangeEnd = 148643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveItemData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_GetSaveData_Public_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveItemData>(intPtr3) : null;
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x001416F8 File Offset: 0x0013F8F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 148675, RefRangeEnd = 148679, XrefRangeStart = 148647, XrefRangeEnd = 148675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(MoveItemData moveItemData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moveItemData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Load_Public_Void_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x0014173C File Offset: 0x0013F93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148679, XrefRangeEnd = 148680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveItemBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00141778 File Offset: 0x0013F978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148680, XrefRangeEnd = 148685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x001417B8 File Offset: 0x0013F9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148685, XrefRangeEnd = 148687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalkToSource_b__26_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr__WalkToSource_b__26_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x001417F4 File Offset: 0x0013F9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148687, XrefRangeEnd = 148692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x00141834 File Offset: 0x0013FA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148692, XrefRangeEnd = 148697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x00141874 File Offset: 0x0013FA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalkToDestination_b__29_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr__WalkToDestination_b__29_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x001418B0 File Offset: 0x0013FAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148697, XrefRangeEnd = 148702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x001418F0 File Offset: 0x0013FAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148702, XrefRangeEnd = 148703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x0014192C File Offset: 0x0013FB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148703, XrefRangeEnd = 148704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x00141968 File Offset: 0x0013FB68
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x001419A4 File Offset: 0x0013FBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveItemBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x0001FA77 File Offset: 0x0001DC77
		public MoveItemBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x001419E0 File Offset: 0x0013FBE0
		// (set) Token: 0x06003FBA RID: 16314 RVA: 0x0001FA80 File Offset: 0x0001DC80
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06003FBB RID: 16315 RVA: 0x00141A08 File Offset: 0x0013FC08
		// (set) Token: 0x06003FBC RID: 16316 RVA: 0x0001FA9B File Offset: 0x0001DC9B
		public unsafe TransitRoute assignedRoute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_assignedRoute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_assignedRoute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06003FBD RID: 16317 RVA: 0x00141A38 File Offset: 0x0013FC38
		// (set) Token: 0x06003FBE RID: 16318 RVA: 0x0001FABA File Offset: 0x0001DCBA
		public unsafe ItemInstance itemToRetrieveTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_itemToRetrieveTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_itemToRetrieveTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06003FBF RID: 16319 RVA: 0x00141A68 File Offset: 0x0013FC68
		// (set) Token: 0x06003FC0 RID: 16320 RVA: 0x0001FAD9 File Offset: 0x0001DCD9
		public unsafe int grabbedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_grabbedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_grabbedAmount)) = value;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x00141A90 File Offset: 0x0013FC90
		// (set) Token: 0x06003FC2 RID: 16322 RVA: 0x0001FAF4 File Offset: 0x0001DCF4
		public unsafe int maxMoveAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_maxMoveAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_maxMoveAmount)) = value;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x00141AB8 File Offset: 0x0013FCB8
		// (set) Token: 0x06003FC4 RID: 16324 RVA: 0x0001FB0F File Offset: 0x0001DD0F
		public unsafe MoveItemBehaviour.EState currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x00141AE0 File Offset: 0x0013FCE0
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x0001FB2A File Offset: 0x0001DD2A
		public unsafe Coroutine walkToSourceRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_walkToSourceRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_walkToSourceRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06003FC7 RID: 16327 RVA: 0x00141B10 File Offset: 0x0013FD10
		// (set) Token: 0x06003FC8 RID: 16328 RVA: 0x0001FB49 File Offset: 0x0001DD49
		public unsafe Coroutine grabRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_grabRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_grabRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06003FC9 RID: 16329 RVA: 0x00141B40 File Offset: 0x0013FD40
		// (set) Token: 0x06003FCA RID: 16330 RVA: 0x0001FB68 File Offset: 0x0001DD68
		public unsafe Coroutine walkToDestinationRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_walkToDestinationRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_walkToDestinationRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x00141B70 File Offset: 0x0013FD70
		// (set) Token: 0x06003FCC RID: 16332 RVA: 0x0001FB87 File Offset: 0x0001DD87
		public unsafe Coroutine placingRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_placingRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_placingRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x00141BA0 File Offset: 0x0013FDA0
		// (set) Token: 0x06003FCE RID: 16334 RVA: 0x0001FBA6 File Offset: 0x0001DDA6
		public unsafe bool skipPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_skipPickup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_skipPickup)) = value;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x00141BC8 File Offset: 0x0013FDC8
		// (set) Token: 0x06003FD0 RID: 16336 RVA: 0x0001FBC1 File Offset: 0x0001DDC1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06003FD1 RID: 16337 RVA: 0x00141BF0 File Offset: 0x0013FDF0
		// (set) Token: 0x06003FD2 RID: 16338 RVA: 0x0001FBDC File Offset: 0x0001DDDC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeFieldInfoPtr_assignedRoute;

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeFieldInfoPtr_itemToRetrieveTemplate;

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeFieldInfoPtr_grabbedAmount;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeFieldInfoPtr_maxMoveAmount;

		// Token: 0x04002A3B RID: 10811
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeFieldInfoPtr_walkToSourceRoutine;

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeFieldInfoPtr_grabRoutine;

		// Token: 0x04002A3E RID: 10814
		private static readonly IntPtr NativeFieldInfoPtr_walkToDestinationRoutine;

		// Token: 0x04002A3F RID: 10815
		private static readonly IntPtr NativeFieldInfoPtr_placingRoutine;

		// Token: 0x04002A40 RID: 10816
		private static readonly IntPtr NativeFieldInfoPtr_skipPickup;

		// Token: 0x04002A41 RID: 10817
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002A42 RID: 10818
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002A43 RID: 10819
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04002A44 RID: 10820
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0;

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_TransitRoute_ItemInstance_Int32_Boolean_0;

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_TransitRoute_ItemInstance_Int32_0;

		// Token: 0x04002A47 RID: 10823
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002A48 RID: 10824
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002A49 RID: 10825
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002A4A RID: 10826
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002A4B RID: 10827
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002A4C RID: 10828
		private static readonly IntPtr NativeMethodInfoPtr_StartTransit_Private_Void_0;

		// Token: 0x04002A4D RID: 10829
		private static readonly IntPtr NativeMethodInfoPtr_IsNpcInventoryItemValid_Private_Boolean_ItemInstance_0;

		// Token: 0x04002A4E RID: 10830
		private static readonly IntPtr NativeMethodInfoPtr_EndTransit_Private_Void_0;

		// Token: 0x04002A4F RID: 10831
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002A50 RID: 10832
		private static readonly IntPtr NativeMethodInfoPtr_WalkToSource_Public_Void_0;

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeMethodInfoPtr_GrabItem_Public_Void_0;

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeMethodInfoPtr_TakeItem_Private_Void_0;

		// Token: 0x04002A53 RID: 10835
		private static readonly IntPtr NativeMethodInfoPtr_WalkToDestination_Public_Void_0;

		// Token: 0x04002A54 RID: 10836
		private static readonly IntPtr NativeMethodInfoPtr_PlaceItem_Public_Void_0;

		// Token: 0x04002A55 RID: 10837
		private static readonly IntPtr NativeMethodInfoPtr_GetAmountToGrab_Private_Int32_0;

		// Token: 0x04002A56 RID: 10838
		private static readonly IntPtr NativeMethodInfoPtr_StopCurrentActivity_Private_Void_0;

		// Token: 0x04002A57 RID: 10839
		private static readonly IntPtr NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_byref_String_0;

		// Token: 0x04002A58 RID: 10840
		private static readonly IntPtr NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_ItemInstance_byref_String_0;

		// Token: 0x04002A59 RID: 10841
		private static readonly IntPtr NativeMethodInfoPtr_IsTransitRouteValid_Public_Boolean_TransitRoute_String_0;

		// Token: 0x04002A5A RID: 10842
		private static readonly IntPtr NativeMethodInfoPtr_IsDestinationValid_Public_Boolean_TransitRoute_ItemInstance_0;

		// Token: 0x04002A5B RID: 10843
		private static readonly IntPtr NativeMethodInfoPtr_CanGetToSource_Public_Boolean_TransitRoute_0;

		// Token: 0x04002A5C RID: 10844
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceAccessPoint_Private_Transform_TransitRoute_0;

		// Token: 0x04002A5D RID: 10845
		private static readonly IntPtr NativeMethodInfoPtr_IsAtSource_Private_Boolean_0;

		// Token: 0x04002A5E RID: 10846
		private static readonly IntPtr NativeMethodInfoPtr_CanGetToDestination_Public_Boolean_TransitRoute_0;

		// Token: 0x04002A5F RID: 10847
		private static readonly IntPtr NativeMethodInfoPtr_GetDestinationAccessPoint_Private_Transform_TransitRoute_0;

		// Token: 0x04002A60 RID: 10848
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002A61 RID: 10849
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_MoveItemData_0;

		// Token: 0x04002A62 RID: 10850
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_MoveItemData_0;

		// Token: 0x04002A63 RID: 10851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A64 RID: 10852
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002A65 RID: 10853
		private static readonly IntPtr NativeMethodInfoPtr__WalkToSource_b__26_1_Private_Boolean_0;

		// Token: 0x04002A66 RID: 10854
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04002A67 RID: 10855
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x04002A68 RID: 10856
		private static readonly IntPtr NativeMethodInfoPtr__WalkToDestination_b__29_1_Private_Boolean_0;

		// Token: 0x04002A69 RID: 10857
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3;

		// Token: 0x04002A6A RID: 10858
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002A6B RID: 10859
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002A6C RID: 10860
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002A6D RID: 10861
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000948 RID: 2376
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04008745 RID: 34629
			Idle,
			// Token: 0x04008746 RID: 34630
			WalkingToSource,
			// Token: 0x04008747 RID: 34631
			Grabbing,
			// Token: 0x04008748 RID: 34632
			WalkingToDestination,
			// Token: 0x04008749 RID: 34633
			Placing
		}

		// Token: 0x02000949 RID: 2377
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.MoveItemBehaviour+<<GrabItem>g__Routine|27_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600C7E3 RID: 51171 RVA: 0x003077BC File Offset: 0x003059BC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0()
			{
				Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<<GrabItem>g__Routine|27_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, "<>1__state");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, "<>2__current");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, "<>4__this");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100670900);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100670901);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100670902);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100670903);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100670904);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr, 100670905);
			}

			// Token: 0x0600C7E4 RID: 51172 RVA: 0x0030789C File Offset: 0x00305A9C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C7E5 RID: 51173 RVA: 0x003078E4 File Offset: 0x00305AE4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C7E6 RID: 51174 RVA: 0x00307918 File Offset: 0x00305B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148106, XrefRangeEnd = 148120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E52 RID: 15954
			// (get) Token: 0x0600C7E7 RID: 51175 RVA: 0x00307954 File Offset: 0x00305B54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7E8 RID: 51176 RVA: 0x00307994 File Offset: 0x00305B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148120, XrefRangeEnd = 148125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E53 RID: 15955
			// (get) Token: 0x0600C7E9 RID: 51177 RVA: 0x003079C8 File Offset: 0x00305BC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7EA RID: 51178 RVA: 0x000613E8 File Offset: 0x0005F5E8
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E4F RID: 15951
			// (get) Token: 0x0600C7EB RID: 51179 RVA: 0x00307A08 File Offset: 0x00305C08
			// (set) Token: 0x0600C7EC RID: 51180 RVA: 0x000613F1 File Offset: 0x0005F5F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E50 RID: 15952
			// (get) Token: 0x0600C7ED RID: 51181 RVA: 0x00307A30 File Offset: 0x00305C30
			// (set) Token: 0x0600C7EE RID: 51182 RVA: 0x0006140C File Offset: 0x0005F60C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E51 RID: 15953
			// (get) Token: 0x0600C7EF RID: 51183 RVA: 0x00307A60 File Offset: 0x00305C60
			// (set) Token: 0x0600C7F0 RID: 51184 RVA: 0x0006142B File Offset: 0x0005F62B
			public unsafe MoveItemBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400874A RID: 34634
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400874B RID: 34635
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400874C RID: 34636
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400874D RID: 34637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400874E RID: 34638
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400874F RID: 34639
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008750 RID: 34640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008751 RID: 34641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008752 RID: 34642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200094A RID: 2378
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.MoveItemBehaviour+<<PlaceItem>g__Routine|30_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600C7F1 RID: 51185 RVA: 0x00307A90 File Offset: 0x00305C90
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1()
			{
				Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<<PlaceItem>g__Routine|30_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, "<>1__state");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, "<>2__current");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, "<>4__this");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100670906);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100670907);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100670908);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100670909);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100670910);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr, 100670911);
			}

			// Token: 0x0600C7F2 RID: 51186 RVA: 0x00307B70 File Offset: 0x00305D70
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C7F3 RID: 51187 RVA: 0x00307BB8 File Offset: 0x00305DB8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C7F4 RID: 51188 RVA: 0x00307BEC File Offset: 0x00305DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148125, XrefRangeEnd = 148171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E57 RID: 15959
			// (get) Token: 0x0600C7F5 RID: 51189 RVA: 0x00307C28 File Offset: 0x00305E28
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7F6 RID: 51190 RVA: 0x00307C68 File Offset: 0x00305E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148171, XrefRangeEnd = 148176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E58 RID: 15960
			// (get) Token: 0x0600C7F7 RID: 51191 RVA: 0x00307C9C File Offset: 0x00305E9C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7F8 RID: 51192 RVA: 0x0006144A File Offset: 0x0005F64A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E54 RID: 15956
			// (get) Token: 0x0600C7F9 RID: 51193 RVA: 0x00307CDC File Offset: 0x00305EDC
			// (set) Token: 0x0600C7FA RID: 51194 RVA: 0x00061453 File Offset: 0x0005F653
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E55 RID: 15957
			// (get) Token: 0x0600C7FB RID: 51195 RVA: 0x00307D04 File Offset: 0x00305F04
			// (set) Token: 0x0600C7FC RID: 51196 RVA: 0x0006146E File Offset: 0x0005F66E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E56 RID: 15958
			// (get) Token: 0x0600C7FD RID: 51197 RVA: 0x00307D34 File Offset: 0x00305F34
			// (set) Token: 0x0600C7FE RID: 51198 RVA: 0x0006148D File Offset: 0x0005F68D
			public unsafe MoveItemBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008753 RID: 34643
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008754 RID: 34644
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008755 RID: 34645
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008756 RID: 34646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008757 RID: 34647
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008758 RID: 34648
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008759 RID: 34649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400875A RID: 34650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400875B RID: 34651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200094B RID: 2379
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.MoveItemBehaviour+<<WalkToDestination>g__Routine|29_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2 : Il2CppSystem.Object
		{
			// Token: 0x0600C7FF RID: 51199 RVA: 0x00307D64 File Offset: 0x00305F64
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2()
			{
				Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<<WalkToDestination>g__Routine|29_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, "<>1__state");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, "<>2__current");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, "<>4__this");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100670912);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100670913);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100670914);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100670915);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100670916);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr, 100670917);
			}

			// Token: 0x0600C800 RID: 51200 RVA: 0x00307E44 File Offset: 0x00306044
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C801 RID: 51201 RVA: 0x00307E8C File Offset: 0x0030608C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C802 RID: 51202 RVA: 0x00307EC0 File Offset: 0x003060C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148176, XrefRangeEnd = 148181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E5C RID: 15964
			// (get) Token: 0x0600C803 RID: 51203 RVA: 0x00307EFC File Offset: 0x003060FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C804 RID: 51204 RVA: 0x00307F3C File Offset: 0x0030613C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148181, XrefRangeEnd = 148186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E5D RID: 15965
			// (get) Token: 0x0600C805 RID: 51205 RVA: 0x00307F70 File Offset: 0x00306170
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C806 RID: 51206 RVA: 0x000614AC File Offset: 0x0005F6AC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E59 RID: 15961
			// (get) Token: 0x0600C807 RID: 51207 RVA: 0x00307FB0 File Offset: 0x003061B0
			// (set) Token: 0x0600C808 RID: 51208 RVA: 0x000614B5 File Offset: 0x0005F6B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E5A RID: 15962
			// (get) Token: 0x0600C809 RID: 51209 RVA: 0x00307FD8 File Offset: 0x003061D8
			// (set) Token: 0x0600C80A RID: 51210 RVA: 0x000614D0 File Offset: 0x0005F6D0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E5B RID: 15963
			// (get) Token: 0x0600C80B RID: 51211 RVA: 0x00308008 File Offset: 0x00306208
			// (set) Token: 0x0600C80C RID: 51212 RVA: 0x000614EF File Offset: 0x0005F6EF
			public unsafe MoveItemBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400875C RID: 34652
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400875D RID: 34653
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400875E RID: 34654
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400875F RID: 34655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008760 RID: 34656
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008761 RID: 34657
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008762 RID: 34658
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008763 RID: 34659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008764 RID: 34660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200094C RID: 2380
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.MoveItemBehaviour+<<WalkToSource>g__Routine|26_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3 : Il2CppSystem.Object
		{
			// Token: 0x0600C80D RID: 51213 RVA: 0x00308038 File Offset: 0x00306238
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3()
			{
				Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBehaviour>.NativeClassPtr, "<<WalkToSource>g__Routine|26_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, "<>1__state");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, "<>2__current");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, "<>4__this");
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100670918);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100670919);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100670920);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100670921);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100670922);
				MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr, 100670923);
			}

			// Token: 0x0600C80E RID: 51214 RVA: 0x00308118 File Offset: 0x00306318
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C80F RID: 51215 RVA: 0x00308160 File Offset: 0x00306360
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C810 RID: 51216 RVA: 0x00308194 File Offset: 0x00306394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148186, XrefRangeEnd = 148191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E61 RID: 15969
			// (get) Token: 0x0600C811 RID: 51217 RVA: 0x003081D0 File Offset: 0x003063D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C812 RID: 51218 RVA: 0x00308210 File Offset: 0x00306410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148191, XrefRangeEnd = 148203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E62 RID: 15970
			// (get) Token: 0x0600C813 RID: 51219 RVA: 0x00308244 File Offset: 0x00306444
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C814 RID: 51220 RVA: 0x0006150E File Offset: 0x0005F70E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E5E RID: 15966
			// (get) Token: 0x0600C815 RID: 51221 RVA: 0x00308284 File Offset: 0x00306484
			// (set) Token: 0x0600C816 RID: 51222 RVA: 0x00061517 File Offset: 0x0005F717
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E5F RID: 15967
			// (get) Token: 0x0600C817 RID: 51223 RVA: 0x003082AC File Offset: 0x003064AC
			// (set) Token: 0x0600C818 RID: 51224 RVA: 0x00061532 File Offset: 0x0005F732
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E60 RID: 15968
			// (get) Token: 0x0600C819 RID: 51225 RVA: 0x003082DC File Offset: 0x003064DC
			// (set) Token: 0x0600C81A RID: 51226 RVA: 0x00061551 File Offset: 0x0005F751
			public unsafe MoveItemBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMoVoObBoInVoMoOb3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008765 RID: 34661
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008766 RID: 34662
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008767 RID: 34663
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008768 RID: 34664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008769 RID: 34665
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400876A RID: 34666
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400876B RID: 34667
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400876C RID: 34668
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400876D RID: 34669
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
