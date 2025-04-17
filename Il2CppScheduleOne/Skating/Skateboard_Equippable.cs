using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001AB RID: 427
	public class Skateboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06002426 RID: 9254 RVA: 0x000E0938 File Offset: 0x000DEB38
		// Note: this type is marked as 'beforefieldinit'.
		static Skateboard_Equippable()
		{
			Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "Skateboard_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr);
			Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelLerpSpeed");
			Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SurfaceSampleDistance");
			Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SurfaceSampleRayLength");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardSpawnUpwardsShift");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardSpawnAngleLimit");
			Skateboard_Equippable.NativeFieldInfoPtr_MountTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "MountTime");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardMomentumTransfer");
			Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "DismountAngle");
			Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "<IsRiding>k__BackingField");
			Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "<ActiveSkateboard>k__BackingField");
			Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SkateboardPrefab");
			Skateboard_Equippable.NativeFieldInfoPtr_blockDismount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "blockDismount");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelContainer");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelPosition_Raised");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelPosition_Lowered");
			Skateboard_Equippable.NativeFieldInfoPtr_mountTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "mountTime");
			Skateboard_Equippable.NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667298);
			Skateboard_Equippable.NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667299);
			Skateboard_Equippable.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667300);
			Skateboard_Equippable.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667301);
			Skateboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667302);
			Skateboard_Equippable.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667303);
			Skateboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667304);
			Skateboard_Equippable.NativeMethodInfoPtr_UpdateModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667305);
			Skateboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667306);
			Skateboard_Equippable.NativeMethodInfoPtr_Mount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667307);
			Skateboard_Equippable.NativeMethodInfoPtr_Dismount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667308);
			Skateboard_Equippable.NativeMethodInfoPtr_CanMountHere_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667309);
			Skateboard_Equippable.NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667310);
			Skateboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667311);
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000E0BC0 File Offset: 0x000DEDC0
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x000E0BFC File Offset: 0x000DEDFC
		public unsafe bool IsRiding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000E0C3C File Offset: 0x000DEE3C
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x000E0C7C File Offset: 0x000DEE7C
		public unsafe Skateboard ActiveSkateboard
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22967, RefRangeEnd = 22968, XrefRangeStart = 22967, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112879, XrefRangeEnd = 112880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x000E0CC0 File Offset: 0x000DEEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112880, XrefRangeEnd = 112899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x000E0D10 File Offset: 0x000DEF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112899, XrefRangeEnd = 112900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x000E0D54 File Offset: 0x000DEF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112900, XrefRangeEnd = 112946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x000E0D90 File Offset: 0x000DEF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112946, XrefRangeEnd = 112952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_UpdateModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x000E0DC4 File Offset: 0x000DEFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112952, XrefRangeEnd = 112969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x000E0E00 File Offset: 0x000DF000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113000, RefRangeEnd = 113001, XrefRangeStart = 112969, XrefRangeEnd = 113000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Mount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Mount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x000E0E34 File Offset: 0x000DF034
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 113037, RefRangeEnd = 113042, XrefRangeStart = 113001, XrefRangeEnd = 113037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dismount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Dismount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000E0E68 File Offset: 0x000DF068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113042, XrefRangeEnd = 113049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMountHere()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_CanMountHere_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x000E0EA4 File Offset: 0x000DF0A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113106, RefRangeEnd = 113109, XrefRangeStart = 113049, XrefRangeEnd = 113106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pose GetSkateboardSpawnPose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x000E0EE0 File Offset: 0x000DF0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113109, XrefRangeEnd = 113110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Skateboard_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00014541 File Offset: 0x00012741
		public Skateboard_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x000E0F1C File Offset: 0x000DF11C
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x0001454A File Offset: 0x0001274A
		public unsafe static float ModelLerpSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x000E0F38 File Offset: 0x000DF138
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x00014558 File Offset: 0x00012758
		public unsafe static float SurfaceSampleDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance, (void*)(&value));
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x000E0F54 File Offset: 0x000DF154
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x00014566 File Offset: 0x00012766
		public unsafe static float SurfaceSampleRayLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength, (void*)(&value));
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x000E0F70 File Offset: 0x000DF170
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x00014574 File Offset: 0x00012774
		public unsafe static float BoardSpawnUpwardsShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift, (void*)(&value));
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x000E0F8C File Offset: 0x000DF18C
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x00014582 File Offset: 0x00012782
		public unsafe static float BoardSpawnAngleLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit, (void*)(&value));
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x000E0FA8 File Offset: 0x000DF1A8
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x00014590 File Offset: 0x00012790
		public unsafe static float MountTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_MountTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_MountTime, (void*)(&value));
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x000E0FC4 File Offset: 0x000DF1C4
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x0001459E File Offset: 0x0001279E
		public unsafe static float BoardMomentumTransfer
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer, (void*)(&value));
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000E0FE0 File Offset: 0x000DF1E0
		// (set) Token: 0x06002445 RID: 9285 RVA: 0x000145AC File Offset: 0x000127AC
		public unsafe static float DismountAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle, (void*)(&value));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x000E0FFC File Offset: 0x000DF1FC
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x000145BA File Offset: 0x000127BA
		public unsafe bool _IsRiding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000E1024 File Offset: 0x000DF224
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x000145D5 File Offset: 0x000127D5
		public unsafe Skateboard _ActiveSkateboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x000E1054 File Offset: 0x000DF254
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x000145F4 File Offset: 0x000127F4
		public unsafe Skateboard SkateboardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x000E1084 File Offset: 0x000DF284
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x00014613 File Offset: 0x00012813
		public unsafe bool blockDismount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_blockDismount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_blockDismount)) = value;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x000E10AC File Offset: 0x000DF2AC
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x0001462E File Offset: 0x0001282E
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x000E10DC File Offset: 0x000DF2DC
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x0001464D File Offset: 0x0001284D
		public unsafe Transform ModelPosition_Raised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x000E110C File Offset: 0x000DF30C
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x0001466C File Offset: 0x0001286C
		public unsafe Transform ModelPosition_Lowered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x000E113C File Offset: 0x000DF33C
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x0001468B File Offset: 0x0001288B
		public unsafe float mountTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_mountTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_mountTime)) = value;
			}
		}

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeFieldInfoPtr_ModelLerpSpeed;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceSampleDistance;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceSampleRayLength;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeFieldInfoPtr_BoardSpawnUpwardsShift;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeFieldInfoPtr_BoardSpawnAngleLimit;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeFieldInfoPtr_MountTime;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeFieldInfoPtr_BoardMomentumTransfer;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeFieldInfoPtr_DismountAngle;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeFieldInfoPtr__IsRiding_k__BackingField;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSkateboard_k__BackingField;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeFieldInfoPtr_SkateboardPrefab;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeFieldInfoPtr_blockDismount;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr_ModelPosition_Raised;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeFieldInfoPtr_ModelPosition_Lowered;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeFieldInfoPtr_mountTime;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModel_Private_Void_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_Mount_Public_Void_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_Dismount_Public_Void_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_CanMountHere_Private_Boolean_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
