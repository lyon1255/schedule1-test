using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A1 RID: 1185
	public class CasinoGameController : NetworkBehaviour
	{
		// Token: 0x06006715 RID: 26389 RVA: 0x001CFA08 File Offset: 0x001CDC08
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameController()
		{
			Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr);
			CasinoGameController.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "FOV");
			CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "CAMERA_LERP_TIME");
			CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "<IsOpen>k__BackingField");
			CasinoGameController.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "Players");
			CasinoGameController.NativeFieldInfoPtr_Interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "Interaction");
			CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "DefaultCameraTransforms");
			CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "localDefaultCameraTransform");
			CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted");
			CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted");
			CasinoGameController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676369);
			CasinoGameController.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676370);
			CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676371);
			CasinoGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676372);
			CasinoGameController.NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676373);
			CasinoGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676374);
			CasinoGameController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676375);
			CasinoGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676376);
			CasinoGameController.NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676377);
			CasinoGameController.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676378);
			CasinoGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676379);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676380);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676381);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676382);
			CasinoGameController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676383);
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x06006716 RID: 26390 RVA: 0x001CFC18 File Offset: 0x001CDE18
		// (set) Token: 0x06006717 RID: 26391 RVA: 0x001CFC54 File Offset: 0x001CDE54
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06006718 RID: 26392 RVA: 0x001CFC94 File Offset: 0x001CDE94
		public unsafe CasinoGamePlayerData LocalPlayerData
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 208683, RefRangeEnd = 208699, XrefRangeStart = 208677, XrefRangeEnd = 208683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
			}
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x001CFCD4 File Offset: 0x001CDED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208721, RefRangeEnd = 208723, XrefRangeStart = 208699, XrefRangeEnd = 208721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x001CFD10 File Offset: 0x001CDF10
		[CallerCount(0)]
		public unsafe virtual void OnLocalPlayerRequestJoin(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x001CFD60 File Offset: 0x001CDF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208723, RefRangeEnd = 208724, XrefRangeStart = 208723, XrefRangeEnd = 208723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x001CFDB0 File Offset: 0x001CDFB0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x001CFDEC File Offset: 0x001CDFEC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x001CFE28 File Offset: 0x001CE028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208794, RefRangeEnd = 208796, XrefRangeStart = 208724, XrefRangeEnd = 208794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x001CFE64 File Offset: 0x001CE064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208853, RefRangeEnd = 208855, XrefRangeStart = 208796, XrefRangeEnd = 208853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x001CFEA0 File Offset: 0x001CE0A0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134822, XrefRangeStart = 134800, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x001CFEDC File Offset: 0x001CE0DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208855, RefRangeEnd = 208856, XrefRangeStart = 208855, XrefRangeEnd = 208855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x001CFF18 File Offset: 0x001CE118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208856, RefRangeEnd = 208857, XrefRangeStart = 208856, XrefRangeEnd = 208856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x001CFF54 File Offset: 0x001CE154
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x001CFF90 File Offset: 0x001CE190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208857, XrefRangeEnd = 208879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x00030B13 File Offset: 0x0002ED13
		public CasinoGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x001CFFCC File Offset: 0x001CE1CC
		// (set) Token: 0x06006727 RID: 26407 RVA: 0x00030B1C File Offset: 0x0002ED1C
		public unsafe static float FOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CasinoGameController.NativeFieldInfoPtr_FOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CasinoGameController.NativeFieldInfoPtr_FOV, (void*)(&value));
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x001CFFE8 File Offset: 0x001CE1E8
		// (set) Token: 0x06006729 RID: 26409 RVA: 0x00030B2A File Offset: 0x0002ED2A
		public unsafe static float CAMERA_LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x0600672A RID: 26410 RVA: 0x001D0004 File Offset: 0x001CE204
		// (set) Token: 0x0600672B RID: 26411 RVA: 0x00030B38 File Offset: 0x0002ED38
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x0600672C RID: 26412 RVA: 0x001D002C File Offset: 0x001CE22C
		// (set) Token: 0x0600672D RID: 26413 RVA: 0x00030B53 File Offset: 0x0002ED53
		public unsafe CasinoGamePlayers Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x001D005C File Offset: 0x001CE25C
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x00030B72 File Offset: 0x0002ED72
		public unsafe CasinoGameInteraction Interaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Interaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGameInteraction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Interaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x001D008C File Offset: 0x001CE28C
		// (set) Token: 0x06006731 RID: 26417 RVA: 0x00030B91 File Offset: 0x0002ED91
		public unsafe Il2CppReferenceArray<Transform> DefaultCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06006732 RID: 26418 RVA: 0x001D00BC File Offset: 0x001CE2BC
		// (set) Token: 0x06006733 RID: 26419 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		public unsafe Transform localDefaultCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06006734 RID: 26420 RVA: 0x001D00EC File Offset: 0x001CE2EC
		// (set) Token: 0x06006735 RID: 26421 RVA: 0x00030BCF File Offset: 0x0002EDCF
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06006736 RID: 26422 RVA: 0x001D0114 File Offset: 0x001CE314
		// (set) Token: 0x06006737 RID: 26423 RVA: 0x00030BEA File Offset: 0x0002EDEA
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004692 RID: 18066
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x04004693 RID: 18067
		private static readonly IntPtr NativeFieldInfoPtr_CAMERA_LERP_TIME;

		// Token: 0x04004694 RID: 18068
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04004695 RID: 18069
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04004696 RID: 18070
		private static readonly IntPtr NativeFieldInfoPtr_Interaction;

		// Token: 0x04004697 RID: 18071
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCameraTransforms;

		// Token: 0x04004698 RID: 18072
		private static readonly IntPtr NativeFieldInfoPtr_localDefaultCameraTransform;

		// Token: 0x04004699 RID: 18073
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400469A RID: 18074
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400469B RID: 18075
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400469C RID: 18076
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400469D RID: 18077
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0;

		// Token: 0x0400469E RID: 18078
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400469F RID: 18079
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0;

		// Token: 0x040046A0 RID: 18080
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x040046A1 RID: 18081
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x040046A2 RID: 18082
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x040046A3 RID: 18083
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1;

		// Token: 0x040046A4 RID: 18084
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1;

		// Token: 0x040046A5 RID: 18085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046A6 RID: 18086
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040046A7 RID: 18087
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040046A8 RID: 18088
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040046A9 RID: 18089
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
