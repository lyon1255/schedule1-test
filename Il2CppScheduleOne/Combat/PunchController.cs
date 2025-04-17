using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000496 RID: 1174
	public class PunchController : MonoBehaviour
	{
		// Token: 0x0600655F RID: 25951 RVA: 0x001C97A0 File Offset: 0x001C79A0
		// Note: this type is marked as 'beforefieldinit'.
		static PunchController()
		{
			Il2CppClassPointerStore<PunchController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "PunchController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController>.NativeClassPtr);
			PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MAX_PUNCH_LOAD");
			PunchController.NativeFieldInfoPtr_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MIN_COOLDOWN");
			PunchController.NativeFieldInfoPtr_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MAX_COOLDOWN");
			PunchController.NativeFieldInfoPtr_PUNCH_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PUNCH_RANGE");
			PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PUNCH_DEBOUNCE");
			PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<PunchingEnabled>k__BackingField");
			PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<IsPunching>k__BackingField");
			PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "ViewmodelAvatarOffset");
			PunchController.NativeFieldInfoPtr_MinPunchDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinPunchDamage");
			PunchController.NativeFieldInfoPtr_MaxPunchDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxPunchDamage");
			PunchController.NativeFieldInfoPtr_MinPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinPunchForce");
			PunchController.NativeFieldInfoPtr_MaxPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxPunchForce");
			PunchController.NativeFieldInfoPtr_MinStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MinStaminaCost");
			PunchController.NativeFieldInfoPtr_MaxStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "MaxStaminaCost");
			PunchController.NativeFieldInfoPtr_PunchSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PunchSound");
			PunchController.NativeFieldInfoPtr_PunchAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "PunchAnimator");
			PunchController.NativeFieldInfoPtr_punchLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "punchLoad");
			PunchController.NativeFieldInfoPtr_remainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "remainingCooldown");
			PunchController.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "player");
			PunchController.NativeFieldInfoPtr_punchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "punchRoutine");
			PunchController.NativeFieldInfoPtr_itemEquippedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "itemEquippedLastFrame");
			PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "timeSincePunchingEnabled");
			PunchController.NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676118);
			PunchController.NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676119);
			PunchController.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676120);
			PunchController.NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676121);
			PunchController.NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676122);
			PunchController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676123);
			PunchController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676124);
			PunchController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676125);
			PunchController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676126);
			PunchController.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676127);
			PunchController.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676128);
			PunchController.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676129);
			PunchController.NativeMethodInfoPtr_StartLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676130);
			PunchController.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676131);
			PunchController.NativeMethodInfoPtr_Punch_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676132);
			PunchController.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676133);
			PunchController.NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676134);
			PunchController.NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676135);
			PunchController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676136);
			PunchController.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController>.NativeClassPtr, 100676137);
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06006560 RID: 25952 RVA: 0x001C9B18 File Offset: 0x001C7D18
		// (set) Token: 0x06006561 RID: 25953 RVA: 0x001C9B54 File Offset: 0x001C7D54
		public unsafe bool PunchingEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06006562 RID: 25954 RVA: 0x001C9B94 File Offset: 0x001C7D94
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06006563 RID: 25955 RVA: 0x001C9BD0 File Offset: 0x001C7DD0
		// (set) Token: 0x06006564 RID: 25956 RVA: 0x001C9C0C File Offset: 0x001C7E0C
		public unsafe bool IsPunching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x001C9C4C File Offset: 0x001C7E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205698, XrefRangeEnd = 205702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x001C9C80 File Offset: 0x001C7E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205702, XrefRangeEnd = 205714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x001C9CB4 File Offset: 0x001C7EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205714, XrefRangeEnd = 205723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x001C9CE8 File Offset: 0x001C7EE8
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x001C9D1C File Offset: 0x001C7F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205723, XrefRangeEnd = 205725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x001C9D50 File Offset: 0x001C7F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205733, RefRangeEnd = 205734, XrefRangeStart = 205725, XrefRangeEnd = 205733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x001C9D84 File Offset: 0x001C7F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205734, XrefRangeEnd = 205738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x001C9DC0 File Offset: 0x001C7FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205738, XrefRangeEnd = 205769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_StartLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x001C9DF4 File Offset: 0x001C7FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205769, XrefRangeEnd = 205803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x001C9E28 File Offset: 0x001C8028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205819, RefRangeEnd = 205820, XrefRangeStart = 205803, XrefRangeEnd = 205819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Punch(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_Punch_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x001C9E68 File Offset: 0x001C8068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205820, XrefRangeEnd = 205889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteHit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x001C9EA8 File Offset: 0x001C80A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205905, RefRangeEnd = 205907, XrefRangeStart = 205889, XrefRangeEnd = 205905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPunchingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x001C9EE8 File Offset: 0x001C80E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205951, RefRangeEnd = 205952, XrefRangeStart = 205907, XrefRangeEnd = 205951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldBeEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x001C9F24 File Offset: 0x001C8124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205952, XrefRangeEnd = 205953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PunchController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x001C9F60 File Offset: 0x001C8160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205953, XrefRangeEnd = 205954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x0002FF44 File Offset: 0x0002E144
		public PunchController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06006575 RID: 25973 RVA: 0x001C9F94 File Offset: 0x001C8194
		// (set) Token: 0x06006576 RID: 25974 RVA: 0x0002FF4D File Offset: 0x0002E14D
		public unsafe static float MAX_PUNCH_LOAD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MAX_PUNCH_LOAD, (void*)(&value));
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x001C9FB0 File Offset: 0x001C81B0
		// (set) Token: 0x06006578 RID: 25976 RVA: 0x0002FF5B File Offset: 0x0002E15B
		public unsafe static float MIN_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x001C9FCC File Offset: 0x001C81CC
		// (set) Token: 0x0600657A RID: 25978 RVA: 0x0002FF69 File Offset: 0x0002E169
		public unsafe static float MAX_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x0600657B RID: 25979 RVA: 0x001C9FE8 File Offset: 0x001C81E8
		// (set) Token: 0x0600657C RID: 25980 RVA: 0x0002FF77 File Offset: 0x0002E177
		public unsafe static float PUNCH_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_PUNCH_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_PUNCH_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x0600657D RID: 25981 RVA: 0x001CA004 File Offset: 0x001C8204
		// (set) Token: 0x0600657E RID: 25982 RVA: 0x0002FF85 File Offset: 0x0002E185
		public unsafe static float PUNCH_DEBOUNCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PunchController.NativeFieldInfoPtr_PUNCH_DEBOUNCE, (void*)(&value));
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x001CA020 File Offset: 0x001C8220
		// (set) Token: 0x06006580 RID: 25984 RVA: 0x0002FF93 File Offset: 0x0002E193
		public unsafe bool _PunchingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__PunchingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06006581 RID: 25985 RVA: 0x001CA048 File Offset: 0x001C8248
		// (set) Token: 0x06006582 RID: 25986 RVA: 0x0002FFAE File Offset: 0x0002E1AE
		public unsafe bool _IsPunching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr__IsPunching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06006583 RID: 25987 RVA: 0x001CA070 File Offset: 0x001C8270
		// (set) Token: 0x06006584 RID: 25988 RVA: 0x0002FFC9 File Offset: 0x0002E1C9
		public unsafe Vector3 ViewmodelAvatarOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_ViewmodelAvatarOffset)) = value;
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06006585 RID: 25989 RVA: 0x001CA098 File Offset: 0x001C8298
		// (set) Token: 0x06006586 RID: 25990 RVA: 0x0002FFE4 File Offset: 0x0002E1E4
		public unsafe float MinPunchDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchDamage)) = value;
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06006587 RID: 25991 RVA: 0x001CA0C0 File Offset: 0x001C82C0
		// (set) Token: 0x06006588 RID: 25992 RVA: 0x0002FFFF File Offset: 0x0002E1FF
		public unsafe float MaxPunchDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchDamage)) = value;
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x001CA0E8 File Offset: 0x001C82E8
		// (set) Token: 0x0600658A RID: 25994 RVA: 0x0003001A File Offset: 0x0002E21A
		public unsafe float MinPunchForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinPunchForce)) = value;
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x0600658B RID: 25995 RVA: 0x001CA110 File Offset: 0x001C8310
		// (set) Token: 0x0600658C RID: 25996 RVA: 0x00030035 File Offset: 0x0002E235
		public unsafe float MaxPunchForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxPunchForce)) = value;
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x0600658D RID: 25997 RVA: 0x001CA138 File Offset: 0x001C8338
		// (set) Token: 0x0600658E RID: 25998 RVA: 0x00030050 File Offset: 0x0002E250
		public unsafe float MinStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MinStaminaCost)) = value;
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x0600658F RID: 25999 RVA: 0x001CA160 File Offset: 0x001C8360
		// (set) Token: 0x06006590 RID: 26000 RVA: 0x0003006B File Offset: 0x0002E26B
		public unsafe float MaxStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_MaxStaminaCost)) = value;
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06006591 RID: 26001 RVA: 0x001CA188 File Offset: 0x001C8388
		// (set) Token: 0x06006592 RID: 26002 RVA: 0x00030086 File Offset: 0x0002E286
		public unsafe AudioSourceController PunchSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06006593 RID: 26003 RVA: 0x001CA1B8 File Offset: 0x001C83B8
		// (set) Token: 0x06006594 RID: 26004 RVA: 0x000300A5 File Offset: 0x0002E2A5
		public unsafe RuntimeAnimatorController PunchAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_PunchAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06006595 RID: 26005 RVA: 0x001CA1E8 File Offset: 0x001C83E8
		// (set) Token: 0x06006596 RID: 26006 RVA: 0x000300C4 File Offset: 0x0002E2C4
		public unsafe float punchLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchLoad)) = value;
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06006597 RID: 26007 RVA: 0x001CA210 File Offset: 0x001C8410
		// (set) Token: 0x06006598 RID: 26008 RVA: 0x000300DF File Offset: 0x0002E2DF
		public unsafe float remainingCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_remainingCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_remainingCooldown)) = value;
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06006599 RID: 26009 RVA: 0x001CA238 File Offset: 0x001C8438
		// (set) Token: 0x0600659A RID: 26010 RVA: 0x000300FA File Offset: 0x0002E2FA
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x0600659B RID: 26011 RVA: 0x001CA268 File Offset: 0x001C8468
		// (set) Token: 0x0600659C RID: 26012 RVA: 0x00030119 File Offset: 0x0002E319
		public unsafe Coroutine punchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_punchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600659D RID: 26013 RVA: 0x001CA298 File Offset: 0x001C8498
		// (set) Token: 0x0600659E RID: 26014 RVA: 0x00030138 File Offset: 0x0002E338
		public unsafe bool itemEquippedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_itemEquippedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_itemEquippedLastFrame)) = value;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x0600659F RID: 26015 RVA: 0x001CA2C0 File Offset: 0x001C84C0
		// (set) Token: 0x060065A0 RID: 26016 RVA: 0x00030153 File Offset: 0x0002E353
		public unsafe float timeSincePunchingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.NativeFieldInfoPtr_timeSincePunchingEnabled)) = value;
			}
		}

		// Token: 0x0400452F RID: 17711
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PUNCH_LOAD;

		// Token: 0x04004530 RID: 17712
		private static readonly IntPtr NativeFieldInfoPtr_MIN_COOLDOWN;

		// Token: 0x04004531 RID: 17713
		private static readonly IntPtr NativeFieldInfoPtr_MAX_COOLDOWN;

		// Token: 0x04004532 RID: 17714
		private static readonly IntPtr NativeFieldInfoPtr_PUNCH_RANGE;

		// Token: 0x04004533 RID: 17715
		private static readonly IntPtr NativeFieldInfoPtr_PUNCH_DEBOUNCE;

		// Token: 0x04004534 RID: 17716
		private static readonly IntPtr NativeFieldInfoPtr__PunchingEnabled_k__BackingField;

		// Token: 0x04004535 RID: 17717
		private static readonly IntPtr NativeFieldInfoPtr__IsPunching_k__BackingField;

		// Token: 0x04004536 RID: 17718
		private static readonly IntPtr NativeFieldInfoPtr_ViewmodelAvatarOffset;

		// Token: 0x04004537 RID: 17719
		private static readonly IntPtr NativeFieldInfoPtr_MinPunchDamage;

		// Token: 0x04004538 RID: 17720
		private static readonly IntPtr NativeFieldInfoPtr_MaxPunchDamage;

		// Token: 0x04004539 RID: 17721
		private static readonly IntPtr NativeFieldInfoPtr_MinPunchForce;

		// Token: 0x0400453A RID: 17722
		private static readonly IntPtr NativeFieldInfoPtr_MaxPunchForce;

		// Token: 0x0400453B RID: 17723
		private static readonly IntPtr NativeFieldInfoPtr_MinStaminaCost;

		// Token: 0x0400453C RID: 17724
		private static readonly IntPtr NativeFieldInfoPtr_MaxStaminaCost;

		// Token: 0x0400453D RID: 17725
		private static readonly IntPtr NativeFieldInfoPtr_PunchSound;

		// Token: 0x0400453E RID: 17726
		private static readonly IntPtr NativeFieldInfoPtr_PunchAnimator;

		// Token: 0x0400453F RID: 17727
		private static readonly IntPtr NativeFieldInfoPtr_punchLoad;

		// Token: 0x04004540 RID: 17728
		private static readonly IntPtr NativeFieldInfoPtr_remainingCooldown;

		// Token: 0x04004541 RID: 17729
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04004542 RID: 17730
		private static readonly IntPtr NativeFieldInfoPtr_punchRoutine;

		// Token: 0x04004543 RID: 17731
		private static readonly IntPtr NativeFieldInfoPtr_itemEquippedLastFrame;

		// Token: 0x04004544 RID: 17732
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePunchingEnabled;

		// Token: 0x04004545 RID: 17733
		private static readonly IntPtr NativeMethodInfoPtr_get_PunchingEnabled_Public_get_Boolean_0;

		// Token: 0x04004546 RID: 17734
		private static readonly IntPtr NativeMethodInfoPtr_set_PunchingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04004547 RID: 17735
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04004548 RID: 17736
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPunching_Public_get_Boolean_0;

		// Token: 0x04004549 RID: 17737
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPunching_Private_set_Void_Boolean_0;

		// Token: 0x0400454A RID: 17738
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400454B RID: 17739
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400454C RID: 17740
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400454D RID: 17741
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400454E RID: 17742
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCooldown_Private_Void_0;

		// Token: 0x0400454F RID: 17743
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04004550 RID: 17744
		private static readonly IntPtr NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0;

		// Token: 0x04004551 RID: 17745
		private static readonly IntPtr NativeMethodInfoPtr_StartLoad_Private_Void_0;

		// Token: 0x04004552 RID: 17746
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04004553 RID: 17747
		private static readonly IntPtr NativeMethodInfoPtr_Punch_Private_Void_Single_0;

		// Token: 0x04004554 RID: 17748
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0;

		// Token: 0x04004555 RID: 17749
		private static readonly IntPtr NativeMethodInfoPtr_SetPunchingEnabled_Private_Void_Boolean_0;

		// Token: 0x04004556 RID: 17750
		private static readonly IntPtr NativeMethodInfoPtr_ShouldBeEnabled_Private_Boolean_0;

		// Token: 0x04004557 RID: 17751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004558 RID: 17752
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__31_0_Private_Void_0;

		// Token: 0x02000A2F RID: 2607
		[ObfuscatedName("ScheduleOne.Combat.PunchController+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF68 RID: 53096 RVA: 0x0031D120 File Offset: 0x0031B320
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunchController>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr);
				PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "power");
				PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, 100676138);
				PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, 100676139);
			}

			// Token: 0x0600CF69 RID: 53097 RVA: 0x0031D19C File Offset: 0x0031B39C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF6A RID: 53098 RVA: 0x0031D1D8 File Offset: 0x0031B3D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205693, XrefRangeEnd = 205698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CF6B RID: 53099 RVA: 0x00064EA2 File Offset: 0x000630A2
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004075 RID: 16501
			// (get) Token: 0x0600CF6C RID: 53100 RVA: 0x0031D218 File Offset: 0x0031B418
			// (set) Token: 0x0600CF6D RID: 53101 RVA: 0x00064EAB File Offset: 0x000630AB
			public unsafe PunchController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PunchController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004076 RID: 16502
			// (get) Token: 0x0600CF6E RID: 53102 RVA: 0x0031D248 File Offset: 0x0031B448
			// (set) Token: 0x0600CF6F RID: 53103 RVA: 0x00064ECA File Offset: 0x000630CA
			public unsafe float power
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.NativeFieldInfoPtr_power)) = value;
				}
			}

			// Token: 0x04008BE5 RID: 35813
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BE6 RID: 35814
			private static readonly IntPtr NativeFieldInfoPtr_power;

			// Token: 0x04008BE7 RID: 35815
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BE8 RID: 35816
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C56 RID: 3158
			[ObfuscatedName("ScheduleOne.Combat.PunchController+<>c__DisplayClass39_0+<<Punch>g__PunchRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E362 RID: 58210 RVA: 0x00355E60 File Offset: 0x00354060
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0>.NativeClassPtr, "<<Punch>g__PunchRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676140);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676141);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676142);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676143);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676144);
					PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676145);
				}

				// Token: 0x0600E363 RID: 58211 RVA: 0x00355F40 File Offset: 0x00354140
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E364 RID: 58212 RVA: 0x00355F88 File Offset: 0x00354188
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E365 RID: 58213 RVA: 0x00355FBC File Offset: 0x003541BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205672, XrefRangeEnd = 205688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700468F RID: 18063
				// (get) Token: 0x0600E366 RID: 58214 RVA: 0x00355FF8 File Offset: 0x003541F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E367 RID: 58215 RVA: 0x00356038 File Offset: 0x00354238
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205688, XrefRangeEnd = 205693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004690 RID: 18064
				// (get) Token: 0x0600E368 RID: 58216 RVA: 0x0035606C File Offset: 0x0035426C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E369 RID: 58217 RVA: 0x0006ED27 File Offset: 0x0006CF27
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700468C RID: 18060
				// (get) Token: 0x0600E36A RID: 58218 RVA: 0x003560AC File Offset: 0x003542AC
				// (set) Token: 0x0600E36B RID: 58219 RVA: 0x0006ED30 File Offset: 0x0006CF30
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700468D RID: 18061
				// (get) Token: 0x0600E36C RID: 58220 RVA: 0x003560D4 File Offset: 0x003542D4
				// (set) Token: 0x0600E36D RID: 58221 RVA: 0x0006ED4B File Offset: 0x0006CF4B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700468E RID: 18062
				// (get) Token: 0x0600E36E RID: 58222 RVA: 0x00356104 File Offset: 0x00354304
				// (set) Token: 0x0600E36F RID: 58223 RVA: 0x0006ED6A File Offset: 0x0006CF6A
				public unsafe PunchController.__c__DisplayClass39_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PunchController.__c__DisplayClass39_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PunchController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009829 RID: 38953
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400982A RID: 38954
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400982B RID: 38955
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400982C RID: 38956
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400982D RID: 38957
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400982E RID: 38958
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400982F RID: 38959
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009830 RID: 38960
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009831 RID: 38961
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
