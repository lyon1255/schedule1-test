using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003F5 RID: 1013
	public class CountdownExplosion : MonoBehaviour
	{
		// Token: 0x0600542D RID: 21549 RVA: 0x0018B3EC File Offset: 0x001895EC
		// Note: this type is marked as 'beforefieldinit'.
		static CountdownExplosion()
		{
			Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "CountdownExplosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr);
			CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "COUNTDOWN");
			CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TICK_SPACING_MAX");
			CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TICK_SPACING_MIN");
			CountdownExplosion.NativeFieldInfoPtr_TickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TickSound");
			CountdownExplosion.NativeFieldInfoPtr_countdownRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "countdownRoutine");
			CountdownExplosion.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673793);
			CountdownExplosion.NativeMethodInfoPtr_StopCountdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673794);
			CountdownExplosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673795);
			CountdownExplosion.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673796);
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0018B4D0 File Offset: 0x001896D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179806, RefRangeEnd = 179807, XrefRangeStart = 179794, XrefRangeEnd = 179806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x0018B504 File Offset: 0x00189704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17711, RefRangeEnd = 17712, XrefRangeStart = 17711, XrefRangeEnd = 17712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCountdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_StopCountdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x0018B538 File Offset: 0x00189738
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountdownExplosion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x0018B574 File Offset: 0x00189774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179807, XrefRangeEnd = 179812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x0002843B File Offset: 0x0002663B
		public CountdownExplosion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06005433 RID: 21555 RVA: 0x0018B5B4 File Offset: 0x001897B4
		// (set) Token: 0x06005434 RID: 21556 RVA: 0x00028444 File Offset: 0x00026644
		public unsafe static float COUNTDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06005435 RID: 21557 RVA: 0x0018B5D0 File Offset: 0x001897D0
		// (set) Token: 0x06005436 RID: 21558 RVA: 0x00028452 File Offset: 0x00026652
		public unsafe static float TICK_SPACING_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06005437 RID: 21559 RVA: 0x0018B5EC File Offset: 0x001897EC
		// (set) Token: 0x06005438 RID: 21560 RVA: 0x00028460 File Offset: 0x00026660
		public unsafe static float TICK_SPACING_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06005439 RID: 21561 RVA: 0x0018B608 File Offset: 0x00189808
		// (set) Token: 0x0600543A RID: 21562 RVA: 0x0002846E File Offset: 0x0002666E
		public unsafe AudioSourceController TickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_TickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_TickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x0018B638 File Offset: 0x00189838
		// (set) Token: 0x0600543C RID: 21564 RVA: 0x0002848D File Offset: 0x0002668D
		public unsafe Coroutine countdownRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_countdownRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_countdownRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400390A RID: 14602
		private static readonly IntPtr NativeFieldInfoPtr_COUNTDOWN;

		// Token: 0x0400390B RID: 14603
		private static readonly IntPtr NativeFieldInfoPtr_TICK_SPACING_MAX;

		// Token: 0x0400390C RID: 14604
		private static readonly IntPtr NativeFieldInfoPtr_TICK_SPACING_MIN;

		// Token: 0x0400390D RID: 14605
		private static readonly IntPtr NativeFieldInfoPtr_TickSound;

		// Token: 0x0400390E RID: 14606
		private static readonly IntPtr NativeFieldInfoPtr_countdownRoutine;

		// Token: 0x0400390F RID: 14607
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x04003910 RID: 14608
		private static readonly IntPtr NativeMethodInfoPtr_StopCountdown_Public_Void_0;

		// Token: 0x04003911 RID: 14609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003912 RID: 14610
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020009B6 RID: 2486
		[ObfuscatedName("ScheduleOne.FX.CountdownExplosion+<<Trigger>g__Routine|5_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CBE7 RID: 52199 RVA: 0x0031331C File Offset: 0x0031151C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique()
			{
				Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "<<Trigger>g__Routine|5_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<timeUntilNextTick>5__2");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673797);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673798);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673799);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673800);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673801);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673802);
			}

			// Token: 0x0600CBE8 RID: 52200 RVA: 0x00313424 File Offset: 0x00311624
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBE9 RID: 52201 RVA: 0x0031346C File Offset: 0x0031166C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBEA RID: 52202 RVA: 0x003134A0 File Offset: 0x003116A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179776, XrefRangeEnd = 179789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F8B RID: 16267
			// (get) Token: 0x0600CBEB RID: 52203 RVA: 0x003134DC File Offset: 0x003116DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBEC RID: 52204 RVA: 0x0031351C File Offset: 0x0031171C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179789, XrefRangeEnd = 179794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F8C RID: 16268
			// (get) Token: 0x0600CBED RID: 52205 RVA: 0x00313550 File Offset: 0x00311750
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBEE RID: 52206 RVA: 0x00063303 File Offset: 0x00061503
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F86 RID: 16262
			// (get) Token: 0x0600CBEF RID: 52207 RVA: 0x00313590 File Offset: 0x00311790
			// (set) Token: 0x0600CBF0 RID: 52208 RVA: 0x0006330C File Offset: 0x0006150C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F87 RID: 16263
			// (get) Token: 0x0600CBF1 RID: 52209 RVA: 0x003135B8 File Offset: 0x003117B8
			// (set) Token: 0x0600CBF2 RID: 52210 RVA: 0x00063327 File Offset: 0x00061527
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F88 RID: 16264
			// (get) Token: 0x0600CBF3 RID: 52211 RVA: 0x003135E8 File Offset: 0x003117E8
			// (set) Token: 0x0600CBF4 RID: 52212 RVA: 0x00063346 File Offset: 0x00061546
			public unsafe CountdownExplosion __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CountdownExplosion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F89 RID: 16265
			// (get) Token: 0x0600CBF5 RID: 52213 RVA: 0x00313618 File Offset: 0x00311818
			// (set) Token: 0x0600CBF6 RID: 52214 RVA: 0x00063365 File Offset: 0x00061565
			public unsafe float _timeUntilNextTick_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2)) = value;
				}
			}

			// Token: 0x17003F8A RID: 16266
			// (get) Token: 0x0600CBF7 RID: 52215 RVA: 0x00313640 File Offset: 0x00311840
			// (set) Token: 0x0600CBF8 RID: 52216 RVA: 0x00063380 File Offset: 0x00061580
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040089DB RID: 35291
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089DC RID: 35292
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089DD RID: 35293
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089DE RID: 35294
			private static readonly IntPtr NativeFieldInfoPtr__timeUntilNextTick_5__2;

			// Token: 0x040089DF RID: 35295
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040089E0 RID: 35296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089E1 RID: 35297
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089E2 RID: 35298
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089E3 RID: 35299
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089E4 RID: 35300
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089E5 RID: 35301
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
