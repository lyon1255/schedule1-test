using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppVLB
{
	// Token: 0x02000081 RID: 129
	public class EffectFlicker : EffectAbstractBase
	{
		// Token: 0x06000960 RID: 2400 RVA: 0x0008D434 File Offset: 0x0008B634
		// Note: this type is marked as 'beforefieldinit'.
		static EffectFlicker()
		{
			Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectFlicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr);
			EffectFlicker.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "ClassName");
			EffectFlicker.NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "frequency");
			EffectFlicker.NativeFieldInfoPtr_performPauses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "performPauses");
			EffectFlicker.NativeFieldInfoPtr_flickeringDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "flickeringDuration");
			EffectFlicker.NativeFieldInfoPtr_pauseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "pauseDuration");
			EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "restoreIntensityOnPause");
			EffectFlicker.NativeFieldInfoPtr_intensityAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "intensityAmplitude");
			EffectFlicker.NativeFieldInfoPtr_smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "smoothing");
			EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "m_CurrentAdditiveIntensity");
			EffectFlicker.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664295);
			EffectFlicker.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664296);
			EffectFlicker.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664297);
			EffectFlicker.NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664298);
			EffectFlicker.NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664299);
			EffectFlicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100664300);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0008D590 File Offset: 0x0008B790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80159, XrefRangeEnd = 80171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFrom(EffectAbstractBase source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectFlicker.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0008D5E0 File Offset: 0x0008B7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80171, XrefRangeEnd = 80178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectFlicker.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0008D61C File Offset: 0x0008B81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80178, XrefRangeEnd = 80183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0008D65C File Offset: 0x0008B85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80183, XrefRangeEnd = 80188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoFlicker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0008D69C File Offset: 0x0008B89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80193, RefRangeEnd = 80194, XrefRangeStart = 80188, XrefRangeEnd = 80193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expectedDuration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextIntensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0008D6F8 File Offset: 0x0008B8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80194, XrefRangeEnd = 80201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectFlicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0000713D File Offset: 0x0000533D
		public EffectFlicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0008D734 File Offset: 0x0008B934
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00007146 File Offset: 0x00005346
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectFlicker.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectFlicker.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0008D754 File Offset: 0x0008B954
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00007158 File Offset: 0x00005358
		public unsafe float frequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_frequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_frequency)) = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0008D77C File Offset: 0x0008B97C
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x00007173 File Offset: 0x00005373
		public unsafe bool performPauses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_performPauses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_performPauses)) = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0008D7A4 File Offset: 0x0008B9A4
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0000718E File Offset: 0x0000538E
		public unsafe MinMaxRangeFloat flickeringDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_flickeringDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_flickeringDuration)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0008D7CC File Offset: 0x0008B9CC
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x000071A9 File Offset: 0x000053A9
		public unsafe MinMaxRangeFloat pauseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_pauseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_pauseDuration)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0008D7F4 File Offset: 0x0008B9F4
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x000071C4 File Offset: 0x000053C4
		public unsafe bool restoreIntensityOnPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0008D81C File Offset: 0x0008BA1C
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x000071DF File Offset: 0x000053DF
		public unsafe MinMaxRangeFloat intensityAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_intensityAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_intensityAmplitude)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0008D844 File Offset: 0x0008BA44
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x000071FA File Offset: 0x000053FA
		public unsafe float smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_smoothing)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0008D86C File Offset: 0x0008BA6C
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00007215 File Offset: 0x00005415
		public unsafe float m_CurrentAdditiveIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity)) = value;
			}
		}

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_frequency;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_performPauses;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_flickeringDuration;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_pauseDuration;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_restoreIntensityOnPause;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_intensityAmplitude;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr_smoothing;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentAdditiveIntensity;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000817 RID: 2071
		[ObfuscatedName("VLB.EffectFlicker+<CoChangeIntensity>d__13")]
		public sealed class _CoChangeIntensity_d__13 : Object
		{
			// Token: 0x0600BE19 RID: 48665 RVA: 0x002EAB50 File Offset: 0x002E8D50
			// Note: this type is marked as 'beforefieldinit'.
			static _CoChangeIntensity_d__13()
			{
				Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoChangeIntensity>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr);
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "nextIntensity");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "expectedDuration");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<velocity>5__2");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<t>5__3");
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664301);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664302);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664303);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664304);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664305);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100664306);
			}

			// Token: 0x0600BE1A RID: 48666 RVA: 0x002EAC80 File Offset: 0x002E8E80
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoChangeIntensity_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE1B RID: 48667 RVA: 0x002EACC8 File Offset: 0x002E8EC8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE1C RID: 48668 RVA: 0x002EACFC File Offset: 0x002E8EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80132, XrefRangeEnd = 80138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B21 RID: 15137
			// (get) Token: 0x0600BE1D RID: 48669 RVA: 0x002EAD38 File Offset: 0x002E8F38
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE1E RID: 48670 RVA: 0x002EAD78 File Offset: 0x002E8F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80138, XrefRangeEnd = 80143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B22 RID: 15138
			// (get) Token: 0x0600BE1F RID: 48671 RVA: 0x002EADAC File Offset: 0x002E8FAC
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE20 RID: 48672 RVA: 0x0005CFE7 File Offset: 0x0005B1E7
			public _CoChangeIntensity_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B1A RID: 15130
			// (get) Token: 0x0600BE21 RID: 48673 RVA: 0x002EADEC File Offset: 0x002E8FEC
			// (set) Token: 0x0600BE22 RID: 48674 RVA: 0x0005CFF0 File Offset: 0x0005B1F0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B1B RID: 15131
			// (get) Token: 0x0600BE23 RID: 48675 RVA: 0x002EAE14 File Offset: 0x002E9014
			// (set) Token: 0x0600BE24 RID: 48676 RVA: 0x0005D00B File Offset: 0x0005B20B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B1C RID: 15132
			// (get) Token: 0x0600BE25 RID: 48677 RVA: 0x002EAE44 File Offset: 0x002E9044
			// (set) Token: 0x0600BE26 RID: 48678 RVA: 0x0005D02A File Offset: 0x0005B22A
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B1D RID: 15133
			// (get) Token: 0x0600BE27 RID: 48679 RVA: 0x002EAE74 File Offset: 0x002E9074
			// (set) Token: 0x0600BE28 RID: 48680 RVA: 0x0005D049 File Offset: 0x0005B249
			public unsafe float nextIntensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity)) = value;
				}
			}

			// Token: 0x17003B1E RID: 15134
			// (get) Token: 0x0600BE29 RID: 48681 RVA: 0x002EAE9C File Offset: 0x002E909C
			// (set) Token: 0x0600BE2A RID: 48682 RVA: 0x0005D064 File Offset: 0x0005B264
			public unsafe float expectedDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration)) = value;
				}
			}

			// Token: 0x17003B1F RID: 15135
			// (get) Token: 0x0600BE2B RID: 48683 RVA: 0x002EAEC4 File Offset: 0x002E90C4
			// (set) Token: 0x0600BE2C RID: 48684 RVA: 0x0005D07F File Offset: 0x0005B27F
			public unsafe float _velocity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2)) = value;
				}
			}

			// Token: 0x17003B20 RID: 15136
			// (get) Token: 0x0600BE2D RID: 48685 RVA: 0x002EAEEC File Offset: 0x002E90EC
			// (set) Token: 0x0600BE2E RID: 48686 RVA: 0x0005D09A File Offset: 0x0005B29A
			public unsafe float _t_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3)) = value;
				}
			}

			// Token: 0x0400809D RID: 32925
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400809E RID: 32926
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400809F RID: 32927
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040080A0 RID: 32928
			private static readonly IntPtr NativeFieldInfoPtr_nextIntensity;

			// Token: 0x040080A1 RID: 32929
			private static readonly IntPtr NativeFieldInfoPtr_expectedDuration;

			// Token: 0x040080A2 RID: 32930
			private static readonly IntPtr NativeFieldInfoPtr__velocity_5__2;

			// Token: 0x040080A3 RID: 32931
			private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x040080A4 RID: 32932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040080A5 RID: 32933
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080A6 RID: 32934
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040080A7 RID: 32935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040080A8 RID: 32936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080A9 RID: 32937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000818 RID: 2072
		[ObfuscatedName("VLB.EffectFlicker+<CoFlicker>d__12")]
		public sealed class _CoFlicker_d__12 : Object
		{
			// Token: 0x0600BE2F RID: 48687 RVA: 0x002EAF14 File Offset: 0x002E9114
			// Note: this type is marked as 'beforefieldinit'.
			static _CoFlicker_d__12()
			{
				Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoFlicker>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr);
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<remainingDuration>5__2");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<freqDuration>5__3");
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664307);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664308);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664309);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664310);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664311);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100664312);
			}

			// Token: 0x0600BE30 RID: 48688 RVA: 0x002EB01C File Offset: 0x002E921C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoFlicker_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE31 RID: 48689 RVA: 0x002EB064 File Offset: 0x002E9264
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE32 RID: 48690 RVA: 0x002EB098 File Offset: 0x002E9298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80143, XrefRangeEnd = 80149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B28 RID: 15144
			// (get) Token: 0x0600BE33 RID: 48691 RVA: 0x002EB0D4 File Offset: 0x002E92D4
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE34 RID: 48692 RVA: 0x002EB114 File Offset: 0x002E9314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80149, XrefRangeEnd = 80154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B29 RID: 15145
			// (get) Token: 0x0600BE35 RID: 48693 RVA: 0x002EB148 File Offset: 0x002E9348
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE36 RID: 48694 RVA: 0x0005D0B5 File Offset: 0x0005B2B5
			public _CoFlicker_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B23 RID: 15139
			// (get) Token: 0x0600BE37 RID: 48695 RVA: 0x002EB188 File Offset: 0x002E9388
			// (set) Token: 0x0600BE38 RID: 48696 RVA: 0x0005D0BE File Offset: 0x0005B2BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B24 RID: 15140
			// (get) Token: 0x0600BE39 RID: 48697 RVA: 0x002EB1B0 File Offset: 0x002E93B0
			// (set) Token: 0x0600BE3A RID: 48698 RVA: 0x0005D0D9 File Offset: 0x0005B2D9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B25 RID: 15141
			// (get) Token: 0x0600BE3B RID: 48699 RVA: 0x002EB1E0 File Offset: 0x002E93E0
			// (set) Token: 0x0600BE3C RID: 48700 RVA: 0x0005D0F8 File Offset: 0x0005B2F8
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B26 RID: 15142
			// (get) Token: 0x0600BE3D RID: 48701 RVA: 0x002EB210 File Offset: 0x002E9410
			// (set) Token: 0x0600BE3E RID: 48702 RVA: 0x0005D117 File Offset: 0x0005B317
			public unsafe float _remainingDuration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2)) = value;
				}
			}

			// Token: 0x17003B27 RID: 15143
			// (get) Token: 0x0600BE3F RID: 48703 RVA: 0x002EB238 File Offset: 0x002E9438
			// (set) Token: 0x0600BE40 RID: 48704 RVA: 0x0005D132 File Offset: 0x0005B332
			public unsafe float _freqDuration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3)) = value;
				}
			}

			// Token: 0x040080AA RID: 32938
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040080AB RID: 32939
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040080AC RID: 32940
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040080AD RID: 32941
			private static readonly IntPtr NativeFieldInfoPtr__remainingDuration_5__2;

			// Token: 0x040080AE RID: 32942
			private static readonly IntPtr NativeFieldInfoPtr__freqDuration_5__3;

			// Token: 0x040080AF RID: 32943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040080B0 RID: 32944
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080B1 RID: 32945
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040080B2 RID: 32946
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040080B3 RID: 32947
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080B4 RID: 32948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000819 RID: 2073
		[ObfuscatedName("VLB.EffectFlicker+<CoUpdate>d__11")]
		public sealed class _CoUpdate_d__11 : Object
		{
			// Token: 0x0600BE41 RID: 48705 RVA: 0x002EB260 File Offset: 0x002E9460
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__11()
			{
				Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoUpdate>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr);
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664313);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664314);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664315);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664316);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664317);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100664318);
			}

			// Token: 0x0600BE42 RID: 48706 RVA: 0x002EB340 File Offset: 0x002E9540
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE43 RID: 48707 RVA: 0x002EB388 File Offset: 0x002E9588
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE44 RID: 48708 RVA: 0x002EB3BC File Offset: 0x002E95BC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B2D RID: 15149
			// (get) Token: 0x0600BE45 RID: 48709 RVA: 0x002EB3F8 File Offset: 0x002E95F8
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE46 RID: 48710 RVA: 0x002EB438 File Offset: 0x002E9638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80154, XrefRangeEnd = 80159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B2E RID: 15150
			// (get) Token: 0x0600BE47 RID: 48711 RVA: 0x002EB46C File Offset: 0x002E966C
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BE48 RID: 48712 RVA: 0x0005D14D File Offset: 0x0005B34D
			public _CoUpdate_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B2A RID: 15146
			// (get) Token: 0x0600BE49 RID: 48713 RVA: 0x002EB4AC File Offset: 0x002E96AC
			// (set) Token: 0x0600BE4A RID: 48714 RVA: 0x0005D156 File Offset: 0x0005B356
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B2B RID: 15147
			// (get) Token: 0x0600BE4B RID: 48715 RVA: 0x002EB4D4 File Offset: 0x002E96D4
			// (set) Token: 0x0600BE4C RID: 48716 RVA: 0x0005D171 File Offset: 0x0005B371
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B2C RID: 15148
			// (get) Token: 0x0600BE4D RID: 48717 RVA: 0x002EB504 File Offset: 0x002E9704
			// (set) Token: 0x0600BE4E RID: 48718 RVA: 0x0005D190 File Offset: 0x0005B390
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040080B5 RID: 32949
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040080B6 RID: 32950
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040080B7 RID: 32951
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040080B8 RID: 32952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040080B9 RID: 32953
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080BA RID: 32954
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040080BB RID: 32955
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040080BC RID: 32956
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040080BD RID: 32957
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
