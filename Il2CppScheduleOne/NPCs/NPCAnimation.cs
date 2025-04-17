using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D4 RID: 724
	public class NPCAnimation : NetworkBehaviour
	{
		// Token: 0x060033F5 RID: 13301 RVA: 0x00116F44 File Offset: 0x00115144
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAnimation()
		{
			Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr);
			NPCAnimation.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "Avatar");
			NPCAnimation.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "anim");
			NPCAnimation.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "movement");
			NPCAnimation.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "npc");
			NPCAnimation.NativeFieldInfoPtr_velocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "velocityCalculator");
			NPCAnimation.NativeFieldInfoPtr_WalkMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "WalkMapCurve");
			NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted");
			NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted");
			NPCAnimation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669166);
			NPCAnimation.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669167);
			NPCAnimation.NativeMethodInfoPtr_UpdateMovementAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669168);
			NPCAnimation.NativeMethodInfoPtr_SetRagdollActive_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669169);
			NPCAnimation.NativeMethodInfoPtr_ResetVelocityCalculations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669170);
			NPCAnimation.NativeMethodInfoPtr_StandupStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669171);
			NPCAnimation.NativeMethodInfoPtr_StandupDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669172);
			NPCAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669173);
			NPCAnimation.NativeMethodInfoPtr__Start_b__6_0_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669174);
			NPCAnimation.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669175);
			NPCAnimation.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669176);
			NPCAnimation.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669177);
			NPCAnimation.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669178);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00117118 File Offset: 0x00115318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134755, XrefRangeEnd = 134775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x0011714C File Offset: 0x0011534C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134775, XrefRangeEnd = 134776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00117188 File Offset: 0x00115388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134776, XrefRangeEnd = 134784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMovementAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_UpdateMovementAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x001171C4 File Offset: 0x001153C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134784, XrefRangeEnd = 134785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRagdollActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_SetRagdollActive_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00117210 File Offset: 0x00115410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134785, XrefRangeEnd = 134787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVelocityCalculations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr_ResetVelocityCalculations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00117244 File Offset: 0x00115444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134787, XrefRangeEnd = 134795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandupStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr_StandupStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00117278 File Offset: 0x00115478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134795, XrefRangeEnd = 134799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandupDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr_StandupDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x001172AC File Offset: 0x001154AC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134822, XrefRangeStart = 134799, XrefRangeEnd = 134800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x001172E8 File Offset: 0x001154E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__6_0(LandVehicle <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr__Start_b__6_0_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x0011732C File Offset: 0x0011552C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00117368 File Offset: 0x00115568
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x001173A4 File Offset: 0x001155A4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x001173E0 File Offset: 0x001155E0
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x0001B6EB File Offset: 0x000198EB
		public NPCAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x0011741C File Offset: 0x0011561C
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x0001B6F4 File Offset: 0x000198F4
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x0011744C File Offset: 0x0011564C
		// (set) Token: 0x06003407 RID: 13319 RVA: 0x0001B713 File Offset: 0x00019913
		public unsafe AvatarAnimation anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x0011747C File Offset: 0x0011567C
		// (set) Token: 0x06003409 RID: 13321 RVA: 0x0001B732 File Offset: 0x00019932
		public unsafe NPCMovement movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x001174AC File Offset: 0x001156AC
		// (set) Token: 0x0600340B RID: 13323 RVA: 0x0001B751 File Offset: 0x00019951
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x0600340C RID: 13324 RVA: 0x001174DC File Offset: 0x001156DC
		// (set) Token: 0x0600340D RID: 13325 RVA: 0x0001B770 File Offset: 0x00019970
		public unsafe SmoothedVelocityCalculator velocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_velocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_velocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x0011750C File Offset: 0x0011570C
		// (set) Token: 0x0600340F RID: 13327 RVA: 0x0001B78F File Offset: 0x0001998F
		public unsafe AnimationCurve WalkMapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_WalkMapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_WalkMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x0011753C File Offset: 0x0011573C
		// (set) Token: 0x06003411 RID: 13329 RVA: 0x0001B7AE File Offset: 0x000199AE
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x00117564 File Offset: 0x00115764
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x0001B7C9 File Offset: 0x000199C9
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeFieldInfoPtr_velocityCalculator;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeFieldInfoPtr_WalkMapCurve;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdollActive_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_ResetVelocityCalculations_Public_Void_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_StandupStart_Public_Void_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_StandupDone_Public_Void_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_0_Private_Void_LandVehicle_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
