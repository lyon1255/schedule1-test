using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRootMotion.FinalIK;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060C RID: 1548
	public class AvatarLookController : MonoBehaviour
	{
		// Token: 0x060088D5 RID: 35029 RVA: 0x0023FCB0 File Offset: 0x0023DEB0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLookController()
		{
			Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarLookController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr);
			AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookAtPlayerRange");
			AvatarLookController.NativeFieldInfoPtr_EyeContractRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "EyeContractRange");
			AvatarLookController.NativeFieldInfoPtr_AimIKRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AimIKRange");
			AvatarLookController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "DEBUG");
			AvatarLookController.NativeFieldInfoPtr_Aim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "Aim");
			AvatarLookController.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "HeadBone");
			AvatarLookController.NativeFieldInfoPtr_LookForwardTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookForwardTarget");
			AvatarLookController.NativeFieldInfoPtr_LookOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookOrigin");
			AvatarLookController.NativeFieldInfoPtr_Eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "Eyes");
			AvatarLookController.NativeFieldInfoPtr_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "NPC");
			AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AutoLookAtPlayer");
			AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookLerpSpeed");
			AvatarLookController.NativeFieldInfoPtr_AimIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AimIKWeight");
			AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "BodyRotationSpeed");
			AvatarLookController.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "avatar");
			AvatarLookController.NativeFieldInfoPtr_lookAtPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lookAtPos");
			AvatarLookController.NativeFieldInfoPtr_lookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lookAtTarget");
			AvatarLookController.NativeFieldInfoPtr_lastFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameOffset");
			AvatarLookController.NativeFieldInfoPtr_overrideLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideLookAt");
			AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overriddenLookTarget");
			AvatarLookController.NativeFieldInfoPtr_overrideLookPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideLookPriority");
			AvatarLookController.NativeFieldInfoPtr_overrideRotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideRotateBody");
			AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameLookOriginPos");
			AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameLookOriginForward");
			AvatarLookController.NativeFieldInfoPtr_ForceLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "ForceLookTarget");
			AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "ForceLookRotateBody");
			AvatarLookController.NativeFieldInfoPtr_defaultIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "defaultIKWeight");
			AvatarLookController.NativeFieldInfoPtr_nearestPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "nearestPlayer");
			AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "nearestPlayerDist");
			AvatarLookController.NativeFieldInfoPtr_localPlayerDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "localPlayerDist");
			AvatarLookController.NativeFieldInfoPtr_cullRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "cullRange");
			AvatarLookController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680352);
			AvatarLookController.NativeMethodInfoPtr_UpdateShit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680353);
			AvatarLookController.NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680354);
			AvatarLookController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680355);
			AvatarLookController.NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680356);
			AvatarLookController.NativeMethodInfoPtr_LookForward_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680357);
			AvatarLookController.NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680358);
			AvatarLookController.NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680359);
			AvatarLookController.NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680360);
			AvatarLookController.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680361);
			AvatarLookController.NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680362);
			AvatarLookController.NativeMethodInfoPtr_ResetIKWeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680363);
			AvatarLookController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680364);
			AvatarLookController.NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680365);
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x00240064 File Offset: 0x0023E264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252763, XrefRangeEnd = 252806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x00240098 File Offset: 0x0023E298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252824, RefRangeEnd = 252825, XrefRangeStart = 252806, XrefRangeEnd = 252824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_UpdateShit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x002400CC File Offset: 0x0023E2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252825, XrefRangeEnd = 252880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNearestPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x00240100 File Offset: 0x0023E300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252880, XrefRangeEnd = 252931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x00240134 File Offset: 0x0023E334
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 252948, RefRangeEnd = 252964, XrefRangeStart = 252931, XrefRangeEnd = 252948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotateBody;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x00240190 File Offset: 0x0023E390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252975, RefRangeEnd = 252976, XrefRangeStart = 252964, XrefRangeEnd = 252975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LookForward_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x002401C4 File Offset: 0x0023E3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252994, RefRangeEnd = 252995, XrefRangeStart = 252976, XrefRangeEnd = 252994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpTargetTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x002401F8 File Offset: 0x0023E3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252995, XrefRangeEnd = 253012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetNearestPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x00240238 File Offset: 0x0023E438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253021, RefRangeEnd = 253022, XrefRangeStart = 253012, XrefRangeEnd = 253021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanLookAt(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x00240284 File Offset: 0x0023E484
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ragdoll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x002402E0 File Offset: 0x0023E4E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253024, RefRangeEnd = 253027, XrefRangeStart = 253022, XrefRangeEnd = 253024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideIKWeight(float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x00240320 File Offset: 0x0023E520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253029, RefRangeEnd = 253030, XrefRangeStart = 253027, XrefRangeEnd = 253029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetIKWeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_ResetIKWeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x00240354 File Offset: 0x0023E554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253030, XrefRangeEnd = 253037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLookController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x00240390 File Offset: 0x0023E590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253037, XrefRangeEnd = 253044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetNearestPlayer_b__38_0(Player p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x00041493 File Offset: 0x0003F693
		public AvatarLookController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x060088E5 RID: 35045 RVA: 0x002403E0 File Offset: 0x0023E5E0
		// (set) Token: 0x060088E6 RID: 35046 RVA: 0x0004149C File Offset: 0x0003F69C
		public unsafe static float LookAtPlayerRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange, (void*)(&value));
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x060088E7 RID: 35047 RVA: 0x002403FC File Offset: 0x0023E5FC
		// (set) Token: 0x060088E8 RID: 35048 RVA: 0x000414AA File Offset: 0x0003F6AA
		public unsafe static float EyeContractRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_EyeContractRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_EyeContractRange, (void*)(&value));
			}
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x060088E9 RID: 35049 RVA: 0x00240418 File Offset: 0x0023E618
		// (set) Token: 0x060088EA RID: 35050 RVA: 0x000414B8 File Offset: 0x0003F6B8
		public unsafe static float AimIKRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_AimIKRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_AimIKRange, (void*)(&value));
			}
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x060088EB RID: 35051 RVA: 0x00240434 File Offset: 0x0023E634
		// (set) Token: 0x060088EC RID: 35052 RVA: 0x000414C6 File Offset: 0x0003F6C6
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x060088ED RID: 35053 RVA: 0x0024045C File Offset: 0x0023E65C
		// (set) Token: 0x060088EE RID: 35054 RVA: 0x000414E1 File Offset: 0x0003F6E1
		public unsafe AimIK Aim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Aim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AimIK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Aim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x060088EF RID: 35055 RVA: 0x0024048C File Offset: 0x0023E68C
		// (set) Token: 0x060088F0 RID: 35056 RVA: 0x00041500 File Offset: 0x0003F700
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x060088F1 RID: 35057 RVA: 0x002404BC File Offset: 0x0023E6BC
		// (set) Token: 0x060088F2 RID: 35058 RVA: 0x0004151F File Offset: 0x0003F71F
		public unsafe Transform LookForwardTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookForwardTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookForwardTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x060088F3 RID: 35059 RVA: 0x002404EC File Offset: 0x0023E6EC
		// (set) Token: 0x060088F4 RID: 35060 RVA: 0x0004153E File Offset: 0x0003F73E
		public unsafe Transform LookOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x060088F5 RID: 35061 RVA: 0x0024051C File Offset: 0x0023E71C
		// (set) Token: 0x060088F6 RID: 35062 RVA: 0x0004155D File Offset: 0x0003F75D
		public unsafe EyeController Eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x060088F7 RID: 35063 RVA: 0x0024054C File Offset: 0x0023E74C
		// (set) Token: 0x060088F8 RID: 35064 RVA: 0x0004157C File Offset: 0x0003F77C
		public unsafe NPC NPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_NPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_NPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x060088F9 RID: 35065 RVA: 0x0024057C File Offset: 0x0023E77C
		// (set) Token: 0x060088FA RID: 35066 RVA: 0x0004159B File Offset: 0x0003F79B
		public unsafe bool AutoLookAtPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer)) = value;
			}
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x060088FB RID: 35067 RVA: 0x002405A4 File Offset: 0x0023E7A4
		// (set) Token: 0x060088FC RID: 35068 RVA: 0x000415B6 File Offset: 0x0003F7B6
		public unsafe float LookLerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed)) = value;
			}
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x060088FD RID: 35069 RVA: 0x002405CC File Offset: 0x0023E7CC
		// (set) Token: 0x060088FE RID: 35070 RVA: 0x000415D1 File Offset: 0x0003F7D1
		public unsafe float AimIKWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AimIKWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AimIKWeight)) = value;
			}
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x060088FF RID: 35071 RVA: 0x002405F4 File Offset: 0x0023E7F4
		// (set) Token: 0x06008900 RID: 35072 RVA: 0x000415EC File Offset: 0x0003F7EC
		public unsafe float BodyRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed)) = value;
			}
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x06008901 RID: 35073 RVA: 0x0024061C File Offset: 0x0023E81C
		// (set) Token: 0x06008902 RID: 35074 RVA: 0x00041607 File Offset: 0x0003F807
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x06008903 RID: 35075 RVA: 0x0024064C File Offset: 0x0023E84C
		// (set) Token: 0x06008904 RID: 35076 RVA: 0x00041626 File Offset: 0x0003F826
		public unsafe Vector3 lookAtPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtPos)) = value;
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x06008905 RID: 35077 RVA: 0x00240674 File Offset: 0x0023E874
		// (set) Token: 0x06008906 RID: 35078 RVA: 0x00041641 File Offset: 0x0003F841
		public unsafe Transform lookAtTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06008907 RID: 35079 RVA: 0x002406A4 File Offset: 0x0023E8A4
		// (set) Token: 0x06008908 RID: 35080 RVA: 0x00041660 File Offset: 0x0003F860
		public unsafe Vector3 lastFrameOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameOffset)) = value;
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06008909 RID: 35081 RVA: 0x002406CC File Offset: 0x0023E8CC
		// (set) Token: 0x0600890A RID: 35082 RVA: 0x0004167B File Offset: 0x0003F87B
		public unsafe bool overrideLookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookAt)) = value;
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x0600890B RID: 35083 RVA: 0x002406F4 File Offset: 0x0023E8F4
		// (set) Token: 0x0600890C RID: 35084 RVA: 0x00041696 File Offset: 0x0003F896
		public unsafe Vector3 overriddenLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget)) = value;
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x0600890D RID: 35085 RVA: 0x0024071C File Offset: 0x0023E91C
		// (set) Token: 0x0600890E RID: 35086 RVA: 0x000416B1 File Offset: 0x0003F8B1
		public unsafe int overrideLookPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookPriority)) = value;
			}
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0600890F RID: 35087 RVA: 0x00240744 File Offset: 0x0023E944
		// (set) Token: 0x06008910 RID: 35088 RVA: 0x000416CC File Offset: 0x0003F8CC
		public unsafe bool overrideRotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideRotateBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideRotateBody)) = value;
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x06008911 RID: 35089 RVA: 0x0024076C File Offset: 0x0023E96C
		// (set) Token: 0x06008912 RID: 35090 RVA: 0x000416E7 File Offset: 0x0003F8E7
		public unsafe Vector3 lastFrameLookOriginPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos)) = value;
			}
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x06008913 RID: 35091 RVA: 0x00240794 File Offset: 0x0023E994
		// (set) Token: 0x06008914 RID: 35092 RVA: 0x00041702 File Offset: 0x0003F902
		public unsafe Vector3 lastFrameLookOriginForward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward)) = value;
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x06008915 RID: 35093 RVA: 0x002407BC File Offset: 0x0023E9BC
		// (set) Token: 0x06008916 RID: 35094 RVA: 0x0004171D File Offset: 0x0003F91D
		public unsafe Transform ForceLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x06008917 RID: 35095 RVA: 0x002407EC File Offset: 0x0023E9EC
		// (set) Token: 0x06008918 RID: 35096 RVA: 0x0004173C File Offset: 0x0003F93C
		public unsafe bool ForceLookRotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody)) = value;
			}
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x06008919 RID: 35097 RVA: 0x00240814 File Offset: 0x0023EA14
		// (set) Token: 0x0600891A RID: 35098 RVA: 0x00041757 File Offset: 0x0003F957
		public unsafe float defaultIKWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_defaultIKWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_defaultIKWeight)) = value;
			}
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x0600891B RID: 35099 RVA: 0x0024083C File Offset: 0x0023EA3C
		// (set) Token: 0x0600891C RID: 35100 RVA: 0x00041772 File Offset: 0x0003F972
		public unsafe Player nearestPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x0600891D RID: 35101 RVA: 0x0024086C File Offset: 0x0023EA6C
		// (set) Token: 0x0600891E RID: 35102 RVA: 0x00041791 File Offset: 0x0003F991
		public unsafe float nearestPlayerDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist)) = value;
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x0600891F RID: 35103 RVA: 0x00240894 File Offset: 0x0023EA94
		// (set) Token: 0x06008920 RID: 35104 RVA: 0x000417AC File Offset: 0x0003F9AC
		public unsafe float localPlayerDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_localPlayerDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_localPlayerDist)) = value;
			}
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x002408BC File Offset: 0x0023EABC
		// (set) Token: 0x06008922 RID: 35106 RVA: 0x000417C7 File Offset: 0x0003F9C7
		public unsafe float cullRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_cullRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_cullRange)) = value;
			}
		}

		// Token: 0x04005CF6 RID: 23798
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPlayerRange;

		// Token: 0x04005CF7 RID: 23799
		private static readonly IntPtr NativeFieldInfoPtr_EyeContractRange;

		// Token: 0x04005CF8 RID: 23800
		private static readonly IntPtr NativeFieldInfoPtr_AimIKRange;

		// Token: 0x04005CF9 RID: 23801
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04005CFA RID: 23802
		private static readonly IntPtr NativeFieldInfoPtr_Aim;

		// Token: 0x04005CFB RID: 23803
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005CFC RID: 23804
		private static readonly IntPtr NativeFieldInfoPtr_LookForwardTarget;

		// Token: 0x04005CFD RID: 23805
		private static readonly IntPtr NativeFieldInfoPtr_LookOrigin;

		// Token: 0x04005CFE RID: 23806
		private static readonly IntPtr NativeFieldInfoPtr_Eyes;

		// Token: 0x04005CFF RID: 23807
		private static readonly IntPtr NativeFieldInfoPtr_NPC;

		// Token: 0x04005D00 RID: 23808
		private static readonly IntPtr NativeFieldInfoPtr_AutoLookAtPlayer;

		// Token: 0x04005D01 RID: 23809
		private static readonly IntPtr NativeFieldInfoPtr_LookLerpSpeed;

		// Token: 0x04005D02 RID: 23810
		private static readonly IntPtr NativeFieldInfoPtr_AimIKWeight;

		// Token: 0x04005D03 RID: 23811
		private static readonly IntPtr NativeFieldInfoPtr_BodyRotationSpeed;

		// Token: 0x04005D04 RID: 23812
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005D05 RID: 23813
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPos;

		// Token: 0x04005D06 RID: 23814
		private static readonly IntPtr NativeFieldInfoPtr_lookAtTarget;

		// Token: 0x04005D07 RID: 23815
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameOffset;

		// Token: 0x04005D08 RID: 23816
		private static readonly IntPtr NativeFieldInfoPtr_overrideLookAt;

		// Token: 0x04005D09 RID: 23817
		private static readonly IntPtr NativeFieldInfoPtr_overriddenLookTarget;

		// Token: 0x04005D0A RID: 23818
		private static readonly IntPtr NativeFieldInfoPtr_overrideLookPriority;

		// Token: 0x04005D0B RID: 23819
		private static readonly IntPtr NativeFieldInfoPtr_overrideRotateBody;

		// Token: 0x04005D0C RID: 23820
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameLookOriginPos;

		// Token: 0x04005D0D RID: 23821
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameLookOriginForward;

		// Token: 0x04005D0E RID: 23822
		private static readonly IntPtr NativeFieldInfoPtr_ForceLookTarget;

		// Token: 0x04005D0F RID: 23823
		private static readonly IntPtr NativeFieldInfoPtr_ForceLookRotateBody;

		// Token: 0x04005D10 RID: 23824
		private static readonly IntPtr NativeFieldInfoPtr_defaultIKWeight;

		// Token: 0x04005D11 RID: 23825
		private static readonly IntPtr NativeFieldInfoPtr_nearestPlayer;

		// Token: 0x04005D12 RID: 23826
		private static readonly IntPtr NativeFieldInfoPtr_nearestPlayerDist;

		// Token: 0x04005D13 RID: 23827
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerDist;

		// Token: 0x04005D14 RID: 23828
		private static readonly IntPtr NativeFieldInfoPtr_cullRange;

		// Token: 0x04005D15 RID: 23829
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005D16 RID: 23830
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShit_Private_Void_0;

		// Token: 0x04005D17 RID: 23831
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0;

		// Token: 0x04005D18 RID: 23832
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005D19 RID: 23833
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0;

		// Token: 0x04005D1A RID: 23834
		private static readonly IntPtr NativeMethodInfoPtr_LookForward_Private_Void_0;

		// Token: 0x04005D1B RID: 23835
		private static readonly IntPtr NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0;

		// Token: 0x04005D1C RID: 23836
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0;

		// Token: 0x04005D1D RID: 23837
		private static readonly IntPtr NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0;

		// Token: 0x04005D1E RID: 23838
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005D1F RID: 23839
		private static readonly IntPtr NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0;

		// Token: 0x04005D20 RID: 23840
		private static readonly IntPtr NativeMethodInfoPtr_ResetIKWeight_Public_Void_0;

		// Token: 0x04005D21 RID: 23841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005D22 RID: 23842
		private static readonly IntPtr NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0;
	}
}
