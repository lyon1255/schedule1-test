using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006A9 RID: 1705
	public class DeliveryApp : App<DeliveryApp>
	{
		// Token: 0x060098B9 RID: 39097 RVA: 0x0026F33C File Offset: 0x0026D53C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryApp()
		{
			Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr);
			DeliveryApp.NativeFieldInfoPtr_deliveryShops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "deliveryShops");
			DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "StatusDisplayPrefab");
			DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "OrderSubmittedAnim");
			DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "OrderSubmittedSound");
			DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "StatusDisplayContainer");
			DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "NoDeliveriesIndicator");
			DeliveryApp.NativeFieldInfoPtr_MainScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "MainScrollRect");
			DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "MainLayoutGroup");
			DeliveryApp.NativeFieldInfoPtr_statusDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "statusDisplays");
			DeliveryApp.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "started");
			DeliveryApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682143);
			DeliveryApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682144);
			DeliveryApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682145);
			DeliveryApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682146);
			DeliveryApp.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682147);
			DeliveryApp.NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682148);
			DeliveryApp.NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682149);
			DeliveryApp.NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682150);
			DeliveryApp.NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682151);
			DeliveryApp.NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682152);
			DeliveryApp.NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682153);
			DeliveryApp.NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682154);
			DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682155);
			DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682156);
			DeliveryApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682157);
		}

		// Token: 0x060098BA RID: 39098 RVA: 0x0026F560 File Offset: 0x0026D760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272543, XrefRangeEnd = 272553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x0026F59C File Offset: 0x0026D79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272553, XrefRangeEnd = 272622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x0026F5D8 File Offset: 0x0026D7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272622, XrefRangeEnd = 272625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x0026F614 File Offset: 0x0026D814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272625, XrefRangeEnd = 272669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x0026F660 File Offset: 0x0026D860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272669, XrefRangeEnd = 272685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x0026F694 File Offset: 0x0026D894
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 272698, RefRangeEnd = 272703, XrefRangeStart = 272685, XrefRangeEnd = 272698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshContent(bool keepScrollPosition = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref keepScrollPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x0026F6D4 File Offset: 0x0026D8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272703, XrefRangeEnd = 272705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOrderSubmittedAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x0026F708 File Offset: 0x0026D908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272705, XrefRangeEnd = 272724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDeliveryStatusDisplay(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098C2 RID: 39106 RVA: 0x0026F74C File Offset: 0x0026D94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272724, XrefRangeEnd = 272753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeliveryCompleted(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098C3 RID: 39107 RVA: 0x0026F790 File Offset: 0x0026D990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272782, RefRangeEnd = 272784, XrefRangeStart = 272753, XrefRangeEnd = 272782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortStatusDisplays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x0026F7C4 File Offset: 0x0026D9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272784, XrefRangeEnd = 272788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNoDeliveriesIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x0026F7F8 File Offset: 0x0026D9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272788, XrefRangeEnd = 272809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshLayoutGroupsImmediateAndRecursive(GameObject root)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x0026F830 File Offset: 0x0026DA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272809, XrefRangeEnd = 272824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop GetShop(ShopInterface matchingShop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchingShop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr3) : null;
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x0026F880 File Offset: 0x0026DA80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272839, RefRangeEnd = 272840, XrefRangeStart = 272824, XrefRangeEnd = 272839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop GetShop(string shopName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr3) : null;
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x0026F8D0 File Offset: 0x0026DAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272840, XrefRangeEnd = 272860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098C9 RID: 39113 RVA: 0x0004A6B2 File Offset: 0x000488B2
		public DeliveryApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x060098CA RID: 39114 RVA: 0x0026F90C File Offset: 0x0026DB0C
		// (set) Token: 0x060098CB RID: 39115 RVA: 0x0004A6BB File Offset: 0x000488BB
		public unsafe List<DeliveryShop> deliveryShops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_deliveryShops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryShop>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_deliveryShops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x060098CC RID: 39116 RVA: 0x0026F93C File Offset: 0x0026DB3C
		// (set) Token: 0x060098CD RID: 39117 RVA: 0x0004A6DA File Offset: 0x000488DA
		public unsafe DeliveryStatusDisplay StatusDisplayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryStatusDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x060098CE RID: 39118 RVA: 0x0026F96C File Offset: 0x0026DB6C
		// (set) Token: 0x060098CF RID: 39119 RVA: 0x0004A6F9 File Offset: 0x000488F9
		public unsafe Animation OrderSubmittedAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x060098D0 RID: 39120 RVA: 0x0026F99C File Offset: 0x0026DB9C
		// (set) Token: 0x060098D1 RID: 39121 RVA: 0x0004A718 File Offset: 0x00048918
		public unsafe AudioSourceController OrderSubmittedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x060098D2 RID: 39122 RVA: 0x0026F9CC File Offset: 0x0026DBCC
		// (set) Token: 0x060098D3 RID: 39123 RVA: 0x0004A737 File Offset: 0x00048937
		public unsafe RectTransform StatusDisplayContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x060098D4 RID: 39124 RVA: 0x0026F9FC File Offset: 0x0026DBFC
		// (set) Token: 0x060098D5 RID: 39125 RVA: 0x0004A756 File Offset: 0x00048956
		public unsafe RectTransform NoDeliveriesIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x060098D6 RID: 39126 RVA: 0x0026FA2C File Offset: 0x0026DC2C
		// (set) Token: 0x060098D7 RID: 39127 RVA: 0x0004A775 File Offset: 0x00048975
		public unsafe ScrollRect MainScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x060098D8 RID: 39128 RVA: 0x0026FA5C File Offset: 0x0026DC5C
		// (set) Token: 0x060098D9 RID: 39129 RVA: 0x0004A794 File Offset: 0x00048994
		public unsafe LayoutGroup MainLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x060098DA RID: 39130 RVA: 0x0026FA8C File Offset: 0x0026DC8C
		// (set) Token: 0x060098DB RID: 39131 RVA: 0x0004A7B3 File Offset: 0x000489B3
		public unsafe List<DeliveryStatusDisplay> statusDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_statusDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryStatusDisplay>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_statusDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x060098DC RID: 39132 RVA: 0x0026FABC File Offset: 0x0026DCBC
		// (set) Token: 0x060098DD RID: 39133 RVA: 0x0004A7D2 File Offset: 0x000489D2
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x040066D6 RID: 26326
		private static readonly IntPtr NativeFieldInfoPtr_deliveryShops;

		// Token: 0x040066D7 RID: 26327
		private static readonly IntPtr NativeFieldInfoPtr_StatusDisplayPrefab;

		// Token: 0x040066D8 RID: 26328
		private static readonly IntPtr NativeFieldInfoPtr_OrderSubmittedAnim;

		// Token: 0x040066D9 RID: 26329
		private static readonly IntPtr NativeFieldInfoPtr_OrderSubmittedSound;

		// Token: 0x040066DA RID: 26330
		private static readonly IntPtr NativeFieldInfoPtr_StatusDisplayContainer;

		// Token: 0x040066DB RID: 26331
		private static readonly IntPtr NativeFieldInfoPtr_NoDeliveriesIndicator;

		// Token: 0x040066DC RID: 26332
		private static readonly IntPtr NativeFieldInfoPtr_MainScrollRect;

		// Token: 0x040066DD RID: 26333
		private static readonly IntPtr NativeFieldInfoPtr_MainLayoutGroup;

		// Token: 0x040066DE RID: 26334
		private static readonly IntPtr NativeFieldInfoPtr_statusDisplays;

		// Token: 0x040066DF RID: 26335
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x040066E0 RID: 26336
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040066E1 RID: 26337
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040066E2 RID: 26338
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040066E3 RID: 26339
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040066E4 RID: 26340
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x040066E5 RID: 26341
		private static readonly IntPtr NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0;

		// Token: 0x040066E6 RID: 26342
		private static readonly IntPtr NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0;

		// Token: 0x040066E7 RID: 26343
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0;

		// Token: 0x040066E8 RID: 26344
		private static readonly IntPtr NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0;

		// Token: 0x040066E9 RID: 26345
		private static readonly IntPtr NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0;

		// Token: 0x040066EA RID: 26346
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0;

		// Token: 0x040066EB RID: 26347
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0;

		// Token: 0x040066EC RID: 26348
		private static readonly IntPtr NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0;

		// Token: 0x040066ED RID: 26349
		private static readonly IntPtr NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0;

		// Token: 0x040066EE RID: 26350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B73 RID: 2931
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB14 RID: 56084 RVA: 0x0033E210 File Offset: 0x0033C410
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr);
				DeliveryApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9");
				DeliveryApp.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9__19_0");
				DeliveryApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100682159);
				DeliveryApp.__c.NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100682160);
			}

			// Token: 0x0600DB15 RID: 56085 RVA: 0x0033E28C File Offset: 0x0033C48C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB16 RID: 56086 RVA: 0x0033E2C8 File Offset: 0x0033C4C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272521, XrefRangeEnd = 272523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortStatusDisplays_b__19_0(DeliveryStatusDisplay d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB17 RID: 56087 RVA: 0x0006AB5C File Offset: 0x00068D5C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F7 RID: 17399
			// (get) Token: 0x0600DB18 RID: 56088 RVA: 0x0033E318 File Offset: 0x0033C518
			// (set) Token: 0x0600DB19 RID: 56089 RVA: 0x0006AB65 File Offset: 0x00068D65
			public unsafe static DeliveryApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F8 RID: 17400
			// (get) Token: 0x0600DB1A RID: 56090 RVA: 0x0033E340 File Offset: 0x0033C540
			// (set) Token: 0x0600DB1B RID: 56091 RVA: 0x0006AB77 File Offset: 0x00068D77
			public unsafe static Func<DeliveryStatusDisplay, int> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeliveryStatusDisplay, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092FB RID: 37627
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040092FC RID: 37628
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x040092FD RID: 37629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092FE RID: 37630
			private static readonly IntPtr NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0;
		}

		// Token: 0x02000B74 RID: 2932
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB1C RID: 56092 RVA: 0x0033E368 File Offset: 0x0033C568
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "keepScrollPosition");
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "scrollPos");
				DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, 100682161);
				DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, 100682162);
			}

			// Token: 0x0600DB1D RID: 56093 RVA: 0x0033E3F8 File Offset: 0x0033C5F8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB1E RID: 56094 RVA: 0x0033E434 File Offset: 0x0033C634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272529, XrefRangeEnd = 272534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB1F RID: 56095 RVA: 0x0006AB89 File Offset: 0x00068D89
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F9 RID: 17401
			// (get) Token: 0x0600DB20 RID: 56096 RVA: 0x0033E474 File Offset: 0x0033C674
			// (set) Token: 0x0600DB21 RID: 56097 RVA: 0x0006AB92 File Offset: 0x00068D92
			public unsafe DeliveryApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FA RID: 17402
			// (get) Token: 0x0600DB22 RID: 56098 RVA: 0x0033E4A4 File Offset: 0x0033C6A4
			// (set) Token: 0x0600DB23 RID: 56099 RVA: 0x0006ABB1 File Offset: 0x00068DB1
			public unsafe bool keepScrollPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition)) = value;
				}
			}

			// Token: 0x170043FB RID: 17403
			// (get) Token: 0x0600DB24 RID: 56100 RVA: 0x0033E4CC File Offset: 0x0033C6CC
			// (set) Token: 0x0600DB25 RID: 56101 RVA: 0x0006ABCC File Offset: 0x00068DCC
			public unsafe float scrollPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos)) = value;
				}
			}

			// Token: 0x040092FF RID: 37631
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009300 RID: 37632
			private static readonly IntPtr NativeFieldInfoPtr_keepScrollPosition;

			// Token: 0x04009301 RID: 37633
			private static readonly IntPtr NativeFieldInfoPtr_scrollPos;

			// Token: 0x04009302 RID: 37634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009303 RID: 37635
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7C RID: 3196
			[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass15_0+<<RefreshContent>g__Delay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E618 RID: 58904 RVA: 0x0035DC50 File Offset: 0x0035BE50
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "<<RefreshContent>g__Delay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682163);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682164);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682165);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682166);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682167);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682168);
				}

				// Token: 0x0600E619 RID: 58905 RVA: 0x0035DD30 File Offset: 0x0035BF30
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E61A RID: 58906 RVA: 0x0035DD78 File Offset: 0x0035BF78
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E61B RID: 58907 RVA: 0x0035DDAC File Offset: 0x0035BFAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272523, XrefRangeEnd = 272524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700479E RID: 18334
				// (get) Token: 0x0600E61C RID: 58908 RVA: 0x0035DDE8 File Offset: 0x0035BFE8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E61D RID: 58909 RVA: 0x0035DE28 File Offset: 0x0035C028
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272524, XrefRangeEnd = 272529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700479F RID: 18335
				// (get) Token: 0x0600E61E RID: 58910 RVA: 0x0035DE5C File Offset: 0x0035C05C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E61F RID: 58911 RVA: 0x000704AF File Offset: 0x0006E6AF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700479B RID: 18331
				// (get) Token: 0x0600E620 RID: 58912 RVA: 0x0035DE9C File Offset: 0x0035C09C
				// (set) Token: 0x0600E621 RID: 58913 RVA: 0x000704B8 File Offset: 0x0006E6B8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700479C RID: 18332
				// (get) Token: 0x0600E622 RID: 58914 RVA: 0x0035DEC4 File Offset: 0x0035C0C4
				// (set) Token: 0x0600E623 RID: 58915 RVA: 0x000704D3 File Offset: 0x0006E6D3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700479D RID: 18333
				// (get) Token: 0x0600E624 RID: 58916 RVA: 0x0035DEF4 File Offset: 0x0035C0F4
				// (set) Token: 0x0600E625 RID: 58917 RVA: 0x000704F2 File Offset: 0x0006E6F2
				public unsafe DeliveryApp.__c__DisplayClass15_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp.__c__DisplayClass15_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040099CE RID: 39374
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099CF RID: 39375
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099D0 RID: 39376
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099D1 RID: 39377
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099D2 RID: 39378
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099D3 RID: 39379
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099D4 RID: 39380
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099D5 RID: 39381
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099D6 RID: 39382
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B75 RID: 2933
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB26 RID: 56102 RVA: 0x0033E4F4 File Offset: 0x0033C6F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, "instance");
				DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, 100682169);
				DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, 100682170);
			}

			// Token: 0x0600DB27 RID: 56103 RVA: 0x0033E55C File Offset: 0x0033C75C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB28 RID: 56104 RVA: 0x0033E598 File Offset: 0x0033C798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272534, XrefRangeEnd = 272536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeliveryCompleted_b__0(DeliveryStatusDisplay d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB29 RID: 56105 RVA: 0x0006ABE7 File Offset: 0x00068DE7
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FC RID: 17404
			// (get) Token: 0x0600DB2A RID: 56106 RVA: 0x0033E5E8 File Offset: 0x0033C7E8
			// (set) Token: 0x0600DB2B RID: 56107 RVA: 0x0006ABF0 File Offset: 0x00068DF0
			public unsafe DeliveryInstance instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009304 RID: 37636
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04009305 RID: 37637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009306 RID: 37638
			private static readonly IntPtr NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0;
		}

		// Token: 0x02000B76 RID: 2934
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB2C RID: 56108 RVA: 0x0033E618 File Offset: 0x0033C818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, "matchingShop");
				DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, 100682171);
				DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, 100682172);
			}

			// Token: 0x0600DB2D RID: 56109 RVA: 0x0033E680 File Offset: 0x0033C880
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB2E RID: 56110 RVA: 0x0033E6BC File Offset: 0x0033C8BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272536, XrefRangeEnd = 272541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShop_b__0(DeliveryShop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB2F RID: 56111 RVA: 0x0006AC0F File Offset: 0x00068E0F
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FD RID: 17405
			// (get) Token: 0x0600DB30 RID: 56112 RVA: 0x0033E70C File Offset: 0x0033C90C
			// (set) Token: 0x0600DB31 RID: 56113 RVA: 0x0006AC18 File Offset: 0x00068E18
			public unsafe ShopInterface matchingShop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009307 RID: 37639
			private static readonly IntPtr NativeFieldInfoPtr_matchingShop;

			// Token: 0x04009308 RID: 37640
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009309 RID: 37641
			private static readonly IntPtr NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0;
		}

		// Token: 0x02000B77 RID: 2935
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB32 RID: 56114 RVA: 0x0033E73C File Offset: 0x0033C93C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, "shopName");
				DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, 100682173);
				DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, 100682174);
			}

			// Token: 0x0600DB33 RID: 56115 RVA: 0x0033E7A4 File Offset: 0x0033C9A4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB34 RID: 56116 RVA: 0x0033E7E0 File Offset: 0x0033C9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272541, XrefRangeEnd = 272543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShop_b__0(DeliveryShop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB35 RID: 56117 RVA: 0x0006AC37 File Offset: 0x00068E37
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FE RID: 17406
			// (get) Token: 0x0600DB36 RID: 56118 RVA: 0x0033E830 File Offset: 0x0033CA30
			// (set) Token: 0x0600DB37 RID: 56119 RVA: 0x0006AC40 File Offset: 0x00068E40
			public unsafe string shopName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400930A RID: 37642
			private static readonly IntPtr NativeFieldInfoPtr_shopName;

			// Token: 0x0400930B RID: 37643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400930C RID: 37644
			private static readonly IntPtr NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0;
		}
	}
}
