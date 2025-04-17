using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Police;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000363 RID: 867
	public class SentryBehaviour : Behaviour
	{
		// Token: 0x06004381 RID: 17281 RVA: 0x0014F5C0 File Offset: 0x0014D7C0
		// Note: this type is marked as 'beforefieldinit'.
		static SentryBehaviour()
		{
			Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "SentryBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr);
			SentryBehaviour.NativeFieldInfoPtr_BODY_SEARCH_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "BODY_SEARCH_CHANCE");
			SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FLASHLIGHT_MIN_TIME");
			SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FLASHLIGHT_MAX_TIME");
			SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FLASHLIGHT_ASSET_PATH");
			SentryBehaviour.NativeFieldInfoPtr_UseFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "UseFlashlight");
			SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "flashlightEquipped");
			SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "<AssignedLocation>k__BackingField");
			SentryBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "officer");
			SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted");
			SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted");
			SentryBehaviour.NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671555);
			SentryBehaviour.NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671556);
			SentryBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671557);
			SentryBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671558);
			SentryBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671559);
			SentryBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671560);
			SentryBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671561);
			SentryBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671562);
			SentryBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671563);
			SentryBehaviour.NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671564);
			SentryBehaviour.NativeMethodInfoPtr_UnassignLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671565);
			SentryBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671566);
			SentryBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671567);
			SentryBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671568);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671569);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671570);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671571);
			SentryBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100671572);
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x0014F820 File Offset: 0x0014DA20
		// (set) Token: 0x06004383 RID: 17283 RVA: 0x0014F860 File Offset: 0x0014DA60
		public unsafe SentryLocation AssignedLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115150, XrefRangeEnd = 115151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x0014F8A4 File Offset: 0x0014DAA4
		public unsafe Transform standPoint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 154255, RefRangeEnd = 154257, XrefRangeStart = 154248, XrefRangeEnd = 154255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x0014F8E4 File Offset: 0x0014DAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154257, XrefRangeEnd = 154266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x0014F920 File Offset: 0x0014DB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x0014F95C File Offset: 0x0014DB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x0014F998 File Offset: 0x0014DB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154266, XrefRangeEnd = 154272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x0014F9D4 File Offset: 0x0014DBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154272, XrefRangeEnd = 154278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x0014FA10 File Offset: 0x0014DC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x0014FA4C File Offset: 0x0014DC4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154297, RefRangeEnd = 154298, XrefRangeStart = 154278, XrefRangeEnd = 154297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignLocation(SentryLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x0014FA90 File Offset: 0x0014DC90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154306, RefRangeEnd = 154307, XrefRangeStart = 154298, XrefRangeEnd = 154306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_UnassignLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x0014FAC4 File Offset: 0x0014DCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154307, XrefRangeEnd = 154342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x0014FB00 File Offset: 0x0014DD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154342, XrefRangeEnd = 154350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlashlightEquipped(bool equipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref equipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x0014FB40 File Offset: 0x0014DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0014FB7C File Offset: 0x0014DD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154350, XrefRangeEnd = 154351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x0014FBB8 File Offset: 0x0014DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x0014FBF4 File Offset: 0x0014DDF4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x0014FC30 File Offset: 0x0014DE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154351, XrefRangeEnd = 154360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00021027 File Offset: 0x0001F227
		public SentryBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06004395 RID: 17301 RVA: 0x0014FC6C File Offset: 0x0014DE6C
		// (set) Token: 0x06004396 RID: 17302 RVA: 0x00021030 File Offset: 0x0001F230
		public unsafe static float BODY_SEARCH_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_BODY_SEARCH_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_BODY_SEARCH_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x0014FC88 File Offset: 0x0014DE88
		// (set) Token: 0x06004398 RID: 17304 RVA: 0x0002103E File Offset: 0x0001F23E
		public unsafe static int FLASHLIGHT_MIN_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x0014FCA4 File Offset: 0x0014DEA4
		// (set) Token: 0x0600439A RID: 17306 RVA: 0x0002104C File Offset: 0x0001F24C
		public unsafe int FLASHLIGHT_MAX_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME)) = value;
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x0014FCCC File Offset: 0x0014DECC
		// (set) Token: 0x0600439C RID: 17308 RVA: 0x00021067 File Offset: 0x0001F267
		public unsafe static string FLASHLIGHT_ASSET_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x0014FCEC File Offset: 0x0014DEEC
		// (set) Token: 0x0600439E RID: 17310 RVA: 0x00021079 File Offset: 0x0001F279
		public unsafe bool UseFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_UseFlashlight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_UseFlashlight)) = value;
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x0014FD14 File Offset: 0x0014DF14
		// (set) Token: 0x060043A0 RID: 17312 RVA: 0x00021094 File Offset: 0x0001F294
		public unsafe bool flashlightEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped)) = value;
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060043A1 RID: 17313 RVA: 0x0014FD3C File Offset: 0x0014DF3C
		// (set) Token: 0x060043A2 RID: 17314 RVA: 0x000210AF File Offset: 0x0001F2AF
		public unsafe SentryLocation _AssignedLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x0014FD6C File Offset: 0x0014DF6C
		// (set) Token: 0x060043A4 RID: 17316 RVA: 0x000210CE File Offset: 0x0001F2CE
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x0014FD9C File Offset: 0x0014DF9C
		// (set) Token: 0x060043A6 RID: 17318 RVA: 0x000210ED File Offset: 0x0001F2ED
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x0014FDC4 File Offset: 0x0014DFC4
		// (set) Token: 0x060043A8 RID: 17320 RVA: 0x00021108 File Offset: 0x0001F308
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D33 RID: 11571
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_CHANCE;

		// Token: 0x04002D34 RID: 11572
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME;

		// Token: 0x04002D35 RID: 11573
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME;

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH;

		// Token: 0x04002D37 RID: 11575
		private static readonly IntPtr NativeFieldInfoPtr_UseFlashlight;

		// Token: 0x04002D38 RID: 11576
		private static readonly IntPtr NativeFieldInfoPtr_flashlightEquipped;

		// Token: 0x04002D39 RID: 11577
		private static readonly IntPtr NativeFieldInfoPtr__AssignedLocation_k__BackingField;

		// Token: 0x04002D3A RID: 11578
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04002D3B RID: 11579
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002D3C RID: 11580
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002D3D RID: 11581
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0;

		// Token: 0x04002D3E RID: 11582
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0;

		// Token: 0x04002D3F RID: 11583
		private static readonly IntPtr NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0;

		// Token: 0x04002D40 RID: 11584
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002D41 RID: 11585
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002D42 RID: 11586
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002D43 RID: 11587
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002D44 RID: 11588
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002D45 RID: 11589
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002D46 RID: 11590
		private static readonly IntPtr NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0;

		// Token: 0x04002D47 RID: 11591
		private static readonly IntPtr NativeMethodInfoPtr_UnassignLocation_Public_Void_0;

		// Token: 0x04002D48 RID: 11592
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002D49 RID: 11593
		private static readonly IntPtr NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0;

		// Token: 0x04002D4A RID: 11594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D4B RID: 11595
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002D4C RID: 11596
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002D4D RID: 11597
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002D4E RID: 11598
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
