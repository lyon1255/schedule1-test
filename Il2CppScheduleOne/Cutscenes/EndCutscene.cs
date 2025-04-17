using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x0200047F RID: 1151
	public class EndCutscene : Cutscene
	{
		// Token: 0x060063C3 RID: 25539 RVA: 0x001C4148 File Offset: 0x001C2348
		// Note: this type is marked as 'beforefieldinit'.
		static EndCutscene()
		{
			Il2CppClassPointerStore<EndCutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "EndCutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr);
			EndCutscene.NativeFieldInfoPtr_onStandUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onStandUp");
			EndCutscene.NativeFieldInfoPtr_onRunStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onRunStart");
			EndCutscene.NativeFieldInfoPtr_onEngineStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onEngineStart");
			EndCutscene.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "Avatar");
			EndCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675943);
			EndCutscene.NativeMethodInfoPtr_StandUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675944);
			EndCutscene.NativeMethodInfoPtr_RunStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675945);
			EndCutscene.NativeMethodInfoPtr_EngineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675946);
			EndCutscene.NativeMethodInfoPtr_On3rdPerson_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675947);
			EndCutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100675948);
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x001C4240 File Offset: 0x001C2440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203667, XrefRangeEnd = 203674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x001C427C File Offset: 0x001C247C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203674, XrefRangeEnd = 203681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_StandUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x001C42B0 File Offset: 0x001C24B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203681, XrefRangeEnd = 203688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_RunStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x001C42E4 File Offset: 0x001C24E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203688, XrefRangeEnd = 203695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_EngineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x001C4318 File Offset: 0x001C2518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203695, XrefRangeEnd = 203701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void On3rdPerson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_On3rdPerson_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x001C434C File Offset: 0x001C254C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndCutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x0002F2C7 File Offset: 0x0002D4C7
		public EndCutscene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x060063CB RID: 25547 RVA: 0x001C4388 File Offset: 0x001C2588
		// (set) Token: 0x060063CC RID: 25548 RVA: 0x0002F2D0 File Offset: 0x0002D4D0
		public unsafe UnityEvent onStandUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onStandUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onStandUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x060063CD RID: 25549 RVA: 0x001C43B8 File Offset: 0x001C25B8
		// (set) Token: 0x060063CE RID: 25550 RVA: 0x0002F2EF File Offset: 0x0002D4EF
		public unsafe UnityEvent onRunStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onRunStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onRunStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x060063CF RID: 25551 RVA: 0x001C43E8 File Offset: 0x001C25E8
		// (set) Token: 0x060063D0 RID: 25552 RVA: 0x0002F30E File Offset: 0x0002D50E
		public unsafe UnityEvent onEngineStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onEngineStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onEngineStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x060063D1 RID: 25553 RVA: 0x001C4418 File Offset: 0x001C2618
		// (set) Token: 0x060063D2 RID: 25554 RVA: 0x0002F32D File Offset: 0x0002D52D
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004415 RID: 17429
		private static readonly IntPtr NativeFieldInfoPtr_onStandUp;

		// Token: 0x04004416 RID: 17430
		private static readonly IntPtr NativeFieldInfoPtr_onRunStart;

		// Token: 0x04004417 RID: 17431
		private static readonly IntPtr NativeFieldInfoPtr_onEngineStart;

		// Token: 0x04004418 RID: 17432
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04004419 RID: 17433
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x0400441A RID: 17434
		private static readonly IntPtr NativeMethodInfoPtr_StandUp_Public_Void_0;

		// Token: 0x0400441B RID: 17435
		private static readonly IntPtr NativeMethodInfoPtr_RunStart_Public_Void_0;

		// Token: 0x0400441C RID: 17436
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Public_Void_0;

		// Token: 0x0400441D RID: 17437
		private static readonly IntPtr NativeMethodInfoPtr_On3rdPerson_Public_Void_0;

		// Token: 0x0400441E RID: 17438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
