using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000550 RID: 1360
	public class SmoothedVelocityCalculator : MonoBehaviour
	{
		// Token: 0x060077E1 RID: 30689 RVA: 0x00207524 File Offset: 0x00205724
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothedVelocityCalculator()
		{
			Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SmoothedVelocityCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr);
			SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "Velocity");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "SampleLength");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "MaxReasonableVelocity");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "VelocityHistory");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "maxSamples");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "lastFramePosition");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "zeroOut");
			SmoothedVelocityCalculator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678373);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678374);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678375);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_FlushBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678376);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678377);
			SmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678378);
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x00207658 File Offset: 0x00205858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232089, XrefRangeEnd = 232091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x0020768C File Offset: 0x0020588C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232114, RefRangeEnd = 232115, XrefRangeStart = 232091, XrefRangeEnd = 232114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x002076C8 File Offset: 0x002058C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232126, RefRangeEnd = 232127, XrefRangeStart = 232115, XrefRangeEnd = 232126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAverageVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x00207704 File Offset: 0x00205904
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 232133, RefRangeEnd = 232136, XrefRangeStart = 232127, XrefRangeEnd = 232133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_FlushBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x00207738 File Offset: 0x00205938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232136, XrefRangeEnd = 232148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZeroOut(float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00207778 File Offset: 0x00205978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothedVelocityCalculator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x00038CA2 File Offset: 0x00036EA2
		public SmoothedVelocityCalculator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x060077E9 RID: 30697 RVA: 0x002077B4 File Offset: 0x002059B4
		// (set) Token: 0x060077EA RID: 30698 RVA: 0x00038CAB File Offset: 0x00036EAB
		public unsafe Vector3 Velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity)) = value;
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x060077EB RID: 30699 RVA: 0x002077DC File Offset: 0x002059DC
		// (set) Token: 0x060077EC RID: 30700 RVA: 0x00038CC6 File Offset: 0x00036EC6
		public unsafe float SampleLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength)) = value;
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x060077ED RID: 30701 RVA: 0x00207804 File Offset: 0x00205A04
		// (set) Token: 0x060077EE RID: 30702 RVA: 0x00038CE1 File Offset: 0x00036EE1
		public unsafe float MaxReasonableVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity)) = value;
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x060077EF RID: 30703 RVA: 0x0020782C File Offset: 0x00205A2C
		// (set) Token: 0x060077F0 RID: 30704 RVA: 0x00038CFC File Offset: 0x00036EFC
		public unsafe List<Tuple<Vector3, float>> VelocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<Vector3, float>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x060077F1 RID: 30705 RVA: 0x0020785C File Offset: 0x00205A5C
		// (set) Token: 0x060077F2 RID: 30706 RVA: 0x00038D1B File Offset: 0x00036F1B
		public unsafe int maxSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples)) = value;
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x060077F3 RID: 30707 RVA: 0x00207884 File Offset: 0x00205A84
		// (set) Token: 0x060077F4 RID: 30708 RVA: 0x00038D36 File Offset: 0x00036F36
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x060077F5 RID: 30709 RVA: 0x002078AC File Offset: 0x00205AAC
		// (set) Token: 0x060077F6 RID: 30710 RVA: 0x00038D51 File Offset: 0x00036F51
		public unsafe bool zeroOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut)) = value;
			}
		}

		// Token: 0x040051C1 RID: 20929
		private static readonly IntPtr NativeFieldInfoPtr_Velocity;

		// Token: 0x040051C2 RID: 20930
		private static readonly IntPtr NativeFieldInfoPtr_SampleLength;

		// Token: 0x040051C3 RID: 20931
		private static readonly IntPtr NativeFieldInfoPtr_MaxReasonableVelocity;

		// Token: 0x040051C4 RID: 20932
		private static readonly IntPtr NativeFieldInfoPtr_VelocityHistory;

		// Token: 0x040051C5 RID: 20933
		private static readonly IntPtr NativeFieldInfoPtr_maxSamples;

		// Token: 0x040051C6 RID: 20934
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x040051C7 RID: 20935
		private static readonly IntPtr NativeFieldInfoPtr_zeroOut;

		// Token: 0x040051C8 RID: 20936
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051C9 RID: 20937
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040051CA RID: 20938
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0;

		// Token: 0x040051CB RID: 20939
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Public_Void_0;

		// Token: 0x040051CC RID: 20940
		private static readonly IntPtr NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0;

		// Token: 0x040051CD RID: 20941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA5 RID: 2725
		[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D323 RID: 54051 RVA: 0x003275DC File Offset: 0x003257DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr);
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "duration");
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, 100678379);
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, 100678380);
			}

			// Token: 0x0600D324 RID: 54052 RVA: 0x00327658 File Offset: 0x00325858
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D325 RID: 54053 RVA: 0x00327694 File Offset: 0x00325894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232084, XrefRangeEnd = 232089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D326 RID: 54054 RVA: 0x00066C51 File Offset: 0x00064E51
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700417A RID: 16762
			// (get) Token: 0x0600D327 RID: 54055 RVA: 0x003276D4 File Offset: 0x003258D4
			// (set) Token: 0x0600D328 RID: 54056 RVA: 0x00066C5A File Offset: 0x00064E5A
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700417B RID: 16763
			// (get) Token: 0x0600D329 RID: 54057 RVA: 0x003276FC File Offset: 0x003258FC
			// (set) Token: 0x0600D32A RID: 54058 RVA: 0x00066C75 File Offset: 0x00064E75
			public unsafe SmoothedVelocityCalculator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E46 RID: 36422
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008E47 RID: 36423
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E48 RID: 36424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E49 RID: 36425
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C62 RID: 3170
			[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c__DisplayClass11_0+<<ZeroOut>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E431 RID: 58417 RVA: 0x00358414 File Offset: 0x00356614
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "<<ZeroOut>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678381);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678382);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678383);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678384);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678385);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678386);
				}

				// Token: 0x0600E432 RID: 58418 RVA: 0x003584F4 File Offset: 0x003566F4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E433 RID: 58419 RVA: 0x0035853C File Offset: 0x0035673C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E434 RID: 58420 RVA: 0x00358570 File Offset: 0x00356770
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232074, XrefRangeEnd = 232079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046DF RID: 18143
				// (get) Token: 0x0600E435 RID: 58421 RVA: 0x003585AC File Offset: 0x003567AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E436 RID: 58422 RVA: 0x003585EC File Offset: 0x003567EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232079, XrefRangeEnd = 232084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046E0 RID: 18144
				// (get) Token: 0x0600E437 RID: 58423 RVA: 0x00358620 File Offset: 0x00356820
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E438 RID: 58424 RVA: 0x0006F429 File Offset: 0x0006D629
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046DC RID: 18140
				// (get) Token: 0x0600E439 RID: 58425 RVA: 0x00358660 File Offset: 0x00356860
				// (set) Token: 0x0600E43A RID: 58426 RVA: 0x0006F432 File Offset: 0x0006D632
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046DD RID: 18141
				// (get) Token: 0x0600E43B RID: 58427 RVA: 0x00358688 File Offset: 0x00356888
				// (set) Token: 0x0600E43C RID: 58428 RVA: 0x0006F44D File Offset: 0x0006D64D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046DE RID: 18142
				// (get) Token: 0x0600E43D RID: 58429 RVA: 0x003586B8 File Offset: 0x003568B8
				// (set) Token: 0x0600E43E RID: 58430 RVA: 0x0006F46C File Offset: 0x0006D66C
				public unsafe SmoothedVelocityCalculator.__c__DisplayClass11_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator.__c__DisplayClass11_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098A6 RID: 39078
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098A7 RID: 39079
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098A8 RID: 39080
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098A9 RID: 39081
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098AA RID: 39082
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098AB RID: 39083
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098AC RID: 39084
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098AD RID: 39085
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098AE RID: 39086
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
