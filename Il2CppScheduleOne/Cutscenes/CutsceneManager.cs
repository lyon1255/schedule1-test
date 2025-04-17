using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x0200047E RID: 1150
	public class CutsceneManager : Singleton<CutsceneManager>
	{
		// Token: 0x060063B7 RID: 25527 RVA: 0x001C3F1C File Offset: 0x001C211C
		// Note: this type is marked as 'beforefieldinit'.
		static CutsceneManager()
		{
			Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "CutsceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr);
			CutsceneManager.NativeFieldInfoPtr_Cutscenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "Cutscenes");
			CutsceneManager.NativeFieldInfoPtr_cutsceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "cutsceneName");
			CutsceneManager.NativeFieldInfoPtr_playingCutscene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "playingCutscene");
			CutsceneManager.NativeMethodInfoPtr_RunCutscene_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675937);
			CutsceneManager.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675938);
			CutsceneManager.NativeMethodInfoPtr_Ended_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675939);
			CutsceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100675940);
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x001C3FD8 File Offset: 0x001C21D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203599, XrefRangeEnd = 203625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCutscene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_RunCutscene_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x001C400C File Offset: 0x001C220C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203625, XrefRangeEnd = 203651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x001C4050 File Offset: 0x001C2250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203651, XrefRangeEnd = 203660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_Ended_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x001C4084 File Offset: 0x001C2284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203660, XrefRangeEnd = 203667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutsceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x0002F261 File Offset: 0x0002D461
		public CutsceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x060063BD RID: 25533 RVA: 0x001C40C0 File Offset: 0x001C22C0
		// (set) Token: 0x060063BE RID: 25534 RVA: 0x0002F26A File Offset: 0x0002D46A
		public unsafe List<Cutscene> Cutscenes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_Cutscenes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cutscene>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_Cutscenes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x001C40F0 File Offset: 0x001C22F0
		// (set) Token: 0x060063C0 RID: 25536 RVA: 0x0002F289 File Offset: 0x0002D489
		public unsafe string cutsceneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_cutsceneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_cutsceneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x060063C1 RID: 25537 RVA: 0x001C4118 File Offset: 0x001C2318
		// (set) Token: 0x060063C2 RID: 25538 RVA: 0x0002F2A8 File Offset: 0x0002D4A8
		public unsafe Cutscene playingCutscene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_playingCutscene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cutscene>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_playingCutscene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400440E RID: 17422
		private static readonly IntPtr NativeFieldInfoPtr_Cutscenes;

		// Token: 0x0400440F RID: 17423
		private static readonly IntPtr NativeFieldInfoPtr_cutsceneName;

		// Token: 0x04004410 RID: 17424
		private static readonly IntPtr NativeFieldInfoPtr_playingCutscene;

		// Token: 0x04004411 RID: 17425
		private static readonly IntPtr NativeMethodInfoPtr_RunCutscene_Private_Void_0;

		// Token: 0x04004412 RID: 17426
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x04004413 RID: 17427
		private static readonly IntPtr NativeMethodInfoPtr_Ended_Private_Void_0;

		// Token: 0x04004414 RID: 17428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A29 RID: 2601
		[ObfuscatedName("ScheduleOne.Cutscenes.CutsceneManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600CF35 RID: 53045 RVA: 0x0031C958 File Offset: 0x0031AB58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr);
				CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, "name");
				CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, 100675941);
				CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, 100675942);
			}

			// Token: 0x0600CF36 RID: 53046 RVA: 0x0031C9C0 File Offset: 0x0031ABC0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF37 RID: 53047 RVA: 0x0031C9FC File Offset: 0x0031ABFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Play_b__0(Cutscene c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF38 RID: 53048 RVA: 0x00064CCA File Offset: 0x00062ECA
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004068 RID: 16488
			// (get) Token: 0x0600CF39 RID: 53049 RVA: 0x0031CA4C File Offset: 0x0031AC4C
			// (set) Token: 0x0600CF3A RID: 53050 RVA: 0x00064CD3 File Offset: 0x00062ED3
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008BCE RID: 35790
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008BCF RID: 35791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BD0 RID: 35792
			private static readonly IntPtr NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0;
		}
	}
}
