using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000365 RID: 869
	public class UnconsciousBehaviour : Behaviour
	{
		// Token: 0x060043B6 RID: 17334 RVA: 0x001500C4 File Offset: 0x0014E2C4
		// Note: this type is marked as 'beforefieldinit'.
		static UnconsciousBehaviour()
		{
			Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "UnconsciousBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr);
			UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "SnoreInterval");
			UnconsciousBehaviour.NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "Particles");
			UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "PlaySnoreSounds");
			UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "timeOnLastSnore");
			UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted");
			UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted");
			UnconsciousBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671580);
			UnconsciousBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671581);
			UnconsciousBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671582);
			UnconsciousBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671583);
			UnconsciousBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671584);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671585);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671586);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671587);
			UnconsciousBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671588);
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00150220 File Offset: 0x0014E420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154364, XrefRangeEnd = 154388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x0015025C File Offset: 0x0014E45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154388, XrefRangeEnd = 154401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00150298 File Offset: 0x0014E498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154401, XrefRangeEnd = 154406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x001502D4 File Offset: 0x0014E4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00150310 File Offset: 0x0014E510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154406, XrefRangeEnd = 154407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnconsciousBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnconsciousBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x0015034C File Offset: 0x0014E54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00150388 File Offset: 0x0014E588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x001503C4 File Offset: 0x0014E5C4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00150400 File Offset: 0x0014E600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00021162 File Offset: 0x0001F362
		public UnconsciousBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x060043C1 RID: 17345 RVA: 0x0015043C File Offset: 0x0014E63C
		// (set) Token: 0x060043C2 RID: 17346 RVA: 0x0002116B File Offset: 0x0001F36B
		public unsafe static float SnoreInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval, (void*)(&value));
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x00150458 File Offset: 0x0014E658
		// (set) Token: 0x060043C4 RID: 17348 RVA: 0x00021179 File Offset: 0x0001F379
		public unsafe ParticleSystem Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x00150488 File Offset: 0x0014E688
		// (set) Token: 0x060043C6 RID: 17350 RVA: 0x00021198 File Offset: 0x0001F398
		public unsafe bool PlaySnoreSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds)) = value;
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x001504B0 File Offset: 0x0014E6B0
		// (set) Token: 0x060043C8 RID: 17352 RVA: 0x000211B3 File Offset: 0x0001F3B3
		public unsafe float timeOnLastSnore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore)) = value;
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x001504D8 File Offset: 0x0014E6D8
		// (set) Token: 0x060043CA RID: 17354 RVA: 0x000211CE File Offset: 0x0001F3CE
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x060043CB RID: 17355 RVA: 0x00150500 File Offset: 0x0014E700
		// (set) Token: 0x060043CC RID: 17356 RVA: 0x000211E9 File Offset: 0x0001F3E9
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D58 RID: 11608
		private static readonly IntPtr NativeFieldInfoPtr_SnoreInterval;

		// Token: 0x04002D59 RID: 11609
		private static readonly IntPtr NativeFieldInfoPtr_Particles;

		// Token: 0x04002D5A RID: 11610
		private static readonly IntPtr NativeFieldInfoPtr_PlaySnoreSounds;

		// Token: 0x04002D5B RID: 11611
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastSnore;

		// Token: 0x04002D5C RID: 11612
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002D5D RID: 11613
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002D5E RID: 11614
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002D5F RID: 11615
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002D60 RID: 11616
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002D61 RID: 11617
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002D62 RID: 11618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D63 RID: 11619
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002D64 RID: 11620
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002D65 RID: 11621
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002D66 RID: 11622
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
