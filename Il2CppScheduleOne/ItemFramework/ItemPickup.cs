using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Variables;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E5 RID: 1509
	public class ItemPickup : NetworkBehaviour
	{
		// Token: 0x060083C4 RID: 33732 RVA: 0x00230138 File Offset: 0x0022E338
		// Note: this type is marked as 'beforefieldinit'.
		static ItemPickup()
		{
			Il2CppClassPointerStore<ItemPickup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemPickup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr);
			ItemPickup.NativeFieldInfoPtr_ItemToGive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "ItemToGive");
			ItemPickup.NativeFieldInfoPtr_DestroyOnPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "DestroyOnPickup");
			ItemPickup.NativeFieldInfoPtr_ConditionallyActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "ConditionallyActive");
			ItemPickup.NativeFieldInfoPtr_ActiveCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "ActiveCondition");
			ItemPickup.NativeFieldInfoPtr_Networked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "Networked");
			ItemPickup.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "IntObj");
			ItemPickup.NativeFieldInfoPtr_onPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "onPickup");
			ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted");
			ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted");
			ItemPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679771);
			ItemPickup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679772);
			ItemPickup.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679773);
			ItemPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679774);
			ItemPickup.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679775);
			ItemPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679776);
			ItemPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679777);
			ItemPickup.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679778);
			ItemPickup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679779);
			ItemPickup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679780);
			ItemPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679781);
			ItemPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679782);
			ItemPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679783);
			ItemPickup.NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679784);
			ItemPickup.NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679785);
			ItemPickup.NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679786);
			ItemPickup.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100679787);
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x00230370 File Offset: 0x0022E570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247472, XrefRangeEnd = 247492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x002303AC File Offset: 0x0022E5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247492, XrefRangeEnd = 247520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x002303E0 File Offset: 0x0022E5E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247551, RefRangeEnd = 247552, XrefRangeStart = 247520, XrefRangeEnd = 247551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x00230414 File Offset: 0x0022E614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247552, XrefRangeEnd = 247556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x00230450 File Offset: 0x0022E650
		[CallerCount(0)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x00230484 File Offset: 0x0022E684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247556, XrefRangeEnd = 247561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x002304CC File Offset: 0x0022E6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247593, RefRangeEnd = 247594, XrefRangeStart = 247561, XrefRangeEnd = 247593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x00230508 File Offset: 0x0022E708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247615, RefRangeEnd = 247616, XrefRangeStart = 247594, XrefRangeEnd = 247615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x0023053C File Offset: 0x0022E73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247616, XrefRangeEnd = 247617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemPickup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x00230578 File Offset: 0x0022E778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247617, XrefRangeEnd = 247622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x002305B8 File Offset: 0x0022E7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247622, XrefRangeEnd = 247629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x002305F4 File Offset: 0x0022E7F4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x00230630 File Offset: 0x0022E830
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x0023066C File Offset: 0x0022E86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247629, XrefRangeEnd = 247647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x002306A0 File Offset: 0x0022E8A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247655, RefRangeEnd = 247658, XrefRangeStart = 247647, XrefRangeEnd = 247655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x002306D4 File Offset: 0x0022E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247658, XrefRangeEnd = 247661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x00230738 File Offset: 0x0022E938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247661, XrefRangeEnd = 247681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x0003E932 File Offset: 0x0003CB32
		public ItemPickup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x060083D7 RID: 33751 RVA: 0x00230774 File Offset: 0x0022E974
		// (set) Token: 0x060083D8 RID: 33752 RVA: 0x0003E93B File Offset: 0x0003CB3B
		public unsafe ItemDefinition ItemToGive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ItemToGive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ItemToGive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x060083D9 RID: 33753 RVA: 0x002307A4 File Offset: 0x0022E9A4
		// (set) Token: 0x060083DA RID: 33754 RVA: 0x0003E95A File Offset: 0x0003CB5A
		public unsafe bool DestroyOnPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_DestroyOnPickup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_DestroyOnPickup)) = value;
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x060083DB RID: 33755 RVA: 0x002307CC File Offset: 0x0022E9CC
		// (set) Token: 0x060083DC RID: 33756 RVA: 0x0003E975 File Offset: 0x0003CB75
		public unsafe bool ConditionallyActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ConditionallyActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ConditionallyActive)) = value;
			}
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x060083DD RID: 33757 RVA: 0x002307F4 File Offset: 0x0022E9F4
		// (set) Token: 0x060083DE RID: 33758 RVA: 0x0003E990 File Offset: 0x0003CB90
		public unsafe Condition ActiveCondition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ActiveCondition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Condition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ActiveCondition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x060083DF RID: 33759 RVA: 0x00230824 File Offset: 0x0022EA24
		// (set) Token: 0x060083E0 RID: 33760 RVA: 0x0003E9AF File Offset: 0x0003CBAF
		public unsafe bool Networked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_Networked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_Networked)) = value;
			}
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x060083E1 RID: 33761 RVA: 0x0023084C File Offset: 0x0022EA4C
		// (set) Token: 0x060083E2 RID: 33762 RVA: 0x0003E9CA File Offset: 0x0003CBCA
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x060083E3 RID: 33763 RVA: 0x0023087C File Offset: 0x0022EA7C
		// (set) Token: 0x060083E4 RID: 33764 RVA: 0x0003E9E9 File Offset: 0x0003CBE9
		public unsafe UnityEvent onPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_onPickup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_onPickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x060083E5 RID: 33765 RVA: 0x002308AC File Offset: 0x0022EAAC
		// (set) Token: 0x060083E6 RID: 33766 RVA: 0x0003EA08 File Offset: 0x0003CC08
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x060083E7 RID: 33767 RVA: 0x002308D4 File Offset: 0x0022EAD4
		// (set) Token: 0x060083E8 RID: 33768 RVA: 0x0003EA23 File Offset: 0x0003CC23
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040059AE RID: 22958
		private static readonly IntPtr NativeFieldInfoPtr_ItemToGive;

		// Token: 0x040059AF RID: 22959
		private static readonly IntPtr NativeFieldInfoPtr_DestroyOnPickup;

		// Token: 0x040059B0 RID: 22960
		private static readonly IntPtr NativeFieldInfoPtr_ConditionallyActive;

		// Token: 0x040059B1 RID: 22961
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCondition;

		// Token: 0x040059B2 RID: 22962
		private static readonly IntPtr NativeFieldInfoPtr_Networked;

		// Token: 0x040059B3 RID: 22963
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040059B4 RID: 22964
		private static readonly IntPtr NativeFieldInfoPtr_onPickup;

		// Token: 0x040059B5 RID: 22965
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040059B6 RID: 22966
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040059B7 RID: 22967
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040059B8 RID: 22968
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040059B9 RID: 22969
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040059BA RID: 22970
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1;

		// Token: 0x040059BB RID: 22971
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x040059BC RID: 22972
		private static readonly IntPtr NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0;

		// Token: 0x040059BD RID: 22973
		private static readonly IntPtr NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1;

		// Token: 0x040059BE RID: 22974
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040059BF RID: 22975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040059C0 RID: 22976
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040059C1 RID: 22977
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040059C2 RID: 22978
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040059C3 RID: 22979
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040059C4 RID: 22980
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0;

		// Token: 0x040059C5 RID: 22981
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0;

		// Token: 0x040059C6 RID: 22982
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040059C7 RID: 22983
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000AE7 RID: 2791
		[ObfuscatedName("ScheduleOne.ItemFramework.ItemPickup+<<Init>g__Wait|9_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique : Object
		{
			// Token: 0x0600D540 RID: 54592 RVA: 0x0032D5D0 File Offset: 0x0032B7D0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique()
			{
				Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "<<Init>g__Wait|9_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, "<>1__state");
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, "<>2__current");
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, "<>4__this");
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100679788);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100679789);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100679790);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100679791);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100679792);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100679793);
			}

			// Token: 0x0600D541 RID: 54593 RVA: 0x0032D6B0 File Offset: 0x0032B8B0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D542 RID: 54594 RVA: 0x0032D6F8 File Offset: 0x0032B8F8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D543 RID: 54595 RVA: 0x0032D72C File Offset: 0x0032B92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247443, XrefRangeEnd = 247463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004217 RID: 16919
			// (get) Token: 0x0600D544 RID: 54596 RVA: 0x0032D768 File Offset: 0x0032B968
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D545 RID: 54597 RVA: 0x0032D7A8 File Offset: 0x0032B9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247463, XrefRangeEnd = 247468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004218 RID: 16920
			// (get) Token: 0x0600D546 RID: 54598 RVA: 0x0032D7DC File Offset: 0x0032B9DC
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D547 RID: 54599 RVA: 0x00067C12 File Offset: 0x00065E12
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004214 RID: 16916
			// (get) Token: 0x0600D548 RID: 54600 RVA: 0x0032D81C File Offset: 0x0032BA1C
			// (set) Token: 0x0600D549 RID: 54601 RVA: 0x00067C1B File Offset: 0x00065E1B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004215 RID: 16917
			// (get) Token: 0x0600D54A RID: 54602 RVA: 0x0032D844 File Offset: 0x0032BA44
			// (set) Token: 0x0600D54B RID: 54603 RVA: 0x00067C36 File Offset: 0x00065E36
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004216 RID: 16918
			// (get) Token: 0x0600D54C RID: 54604 RVA: 0x0032D874 File Offset: 0x0032BA74
			// (set) Token: 0x0600D54D RID: 54605 RVA: 0x00067C55 File Offset: 0x00065E55
			public unsafe ItemPickup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F78 RID: 36728
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F79 RID: 36729
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F7A RID: 36730
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F7B RID: 36731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F7C RID: 36732
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F7D RID: 36733
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F7E RID: 36734
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F7F RID: 36735
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F80 RID: 36736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE8 RID: 2792
		[ObfuscatedName("ScheduleOne.ItemFramework.ItemPickup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D54E RID: 54606 RVA: 0x0032D8A4 File Offset: 0x0032BAA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr);
				ItemPickup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr, "<>9");
				ItemPickup.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr, "<>9__9_1");
				ItemPickup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr, 100679795);
				ItemPickup.__c.NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr, 100679796);
			}

			// Token: 0x0600D54F RID: 54607 RVA: 0x0032D920 File Offset: 0x0032BB20
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D550 RID: 54608 RVA: 0x0032D95C File Offset: 0x0032BB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247468, XrefRangeEnd = 247472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__9_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.__c.NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D551 RID: 54609 RVA: 0x00067C74 File Offset: 0x00065E74
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004219 RID: 16921
			// (get) Token: 0x0600D552 RID: 54610 RVA: 0x0032D998 File Offset: 0x0032BB98
			// (set) Token: 0x0600D553 RID: 54611 RVA: 0x00067C7D File Offset: 0x00065E7D
			public unsafe static ItemPickup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ItemPickup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ItemPickup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421A RID: 16922
			// (get) Token: 0x0600D554 RID: 54612 RVA: 0x0032D9C0 File Offset: 0x0032BBC0
			// (set) Token: 0x0600D555 RID: 54613 RVA: 0x00067C8F File Offset: 0x00065E8F
			public unsafe static Func<bool> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ItemPickup.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ItemPickup.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F81 RID: 36737
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F82 RID: 36738
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04008F83 RID: 36739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F84 RID: 36740
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0;
		}
	}
}
