using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x0200016F RID: 367
	public class PoliceChatterVO : VOEmitter
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x000CC38C File Offset: 0x000CA58C
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceChatterVO()
		{
			Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "PoliceChatterVO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr);
			PoliceChatterVO.NativeFieldInfoPtr_StartBeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "StartBeep");
			PoliceChatterVO.NativeFieldInfoPtr_StartEndBeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "StartEndBeep");
			PoliceChatterVO.NativeFieldInfoPtr_Static = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "Static");
			PoliceChatterVO.NativeFieldInfoPtr_chatterRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "chatterRoutine");
			PoliceChatterVO.NativeMethodInfoPtr_Play_Public_Virtual_Void_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666653);
			PoliceChatterVO.NativeMethodInfoPtr_PlayChatter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666654);
			PoliceChatterVO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666655);
			PoliceChatterVO.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666656);
			PoliceChatterVO.NativeMethodInfoPtr__PlayChatter_b__5_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666657);
			PoliceChatterVO.NativeMethodInfoPtr___n__0_Private_Void_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666658);
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000CC484 File Offset: 0x000CA684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106118, XrefRangeEnd = 106127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceChatterVO.NativeMethodInfoPtr_Play_Public_Virtual_Void_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000CC4D0 File Offset: 0x000CA6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106127, XrefRangeEnd = 106135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayChatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr_PlayChatter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x000CC504 File Offset: 0x000CA704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106135, XrefRangeEnd = 106136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceChatterVO() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000CC540 File Offset: 0x000CA740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106136, XrefRangeEnd = 106141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000CC580 File Offset: 0x000CA780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106141, XrefRangeEnd = 106142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayChatter_b__5_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr__PlayChatter_b__5_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000CC5BC File Offset: 0x000CA7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106142, XrefRangeEnd = 106143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __n__0(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr___n__0_Private_Void_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		public PoliceChatterVO(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x000CC5FC File Offset: 0x000CA7FC
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00010AFD File Offset: 0x0000ECFD
		public unsafe AudioSourceController StartBeep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_StartBeep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_StartBeep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x000CC62C File Offset: 0x000CA82C
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00010B1C File Offset: 0x0000ED1C
		public unsafe AudioSourceController StartEndBeep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_StartEndBeep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_StartEndBeep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x000CC65C File Offset: 0x000CA85C
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00010B3B File Offset: 0x0000ED3B
		public unsafe AudioSourceController Static
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_Static);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_Static), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x000CC68C File Offset: 0x000CA88C
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00010B5A File Offset: 0x0000ED5A
		public unsafe Coroutine chatterRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_chatterRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_chatterRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeFieldInfoPtr_StartBeep;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeFieldInfoPtr_StartEndBeep;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeFieldInfoPtr_Static;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeFieldInfoPtr_chatterRoutine;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_EVOLineType_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_PlayChatter_Private_Void_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr__PlayChatter_b__5_1_Private_Boolean_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Void_EVOLineType_0;

		// Token: 0x020008A7 RID: 2215
		[ObfuscatedName("ScheduleOne.VoiceOver.PoliceChatterVO+<<PlayChatter>g__Play|5_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C2D0 RID: 49872 RVA: 0x002F8F44 File Offset: 0x002F7144
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique()
			{
				Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "<<PlayChatter>g__Play|5_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>1__state");
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>2__current");
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>4__this");
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666659);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666660);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666661);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666662);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666663);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666664);
			}

			// Token: 0x0600C2D1 RID: 49873 RVA: 0x002F9024 File Offset: 0x002F7224
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2D2 RID: 49874 RVA: 0x002F906C File Offset: 0x002F726C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2D3 RID: 49875 RVA: 0x002F90A0 File Offset: 0x002F72A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106107, XrefRangeEnd = 106113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CD6 RID: 15574
			// (get) Token: 0x0600C2D4 RID: 49876 RVA: 0x002F90DC File Offset: 0x002F72DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C2D5 RID: 49877 RVA: 0x002F911C File Offset: 0x002F731C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106113, XrefRangeEnd = 106118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CD7 RID: 15575
			// (get) Token: 0x0600C2D6 RID: 49878 RVA: 0x002F9150 File Offset: 0x002F7350
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C2D7 RID: 49879 RVA: 0x0005ECB5 File Offset: 0x0005CEB5
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD3 RID: 15571
			// (get) Token: 0x0600C2D8 RID: 49880 RVA: 0x002F9190 File Offset: 0x002F7390
			// (set) Token: 0x0600C2D9 RID: 49881 RVA: 0x0005ECBE File Offset: 0x0005CEBE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CD4 RID: 15572
			// (get) Token: 0x0600C2DA RID: 49882 RVA: 0x002F91B8 File Offset: 0x002F73B8
			// (set) Token: 0x0600C2DB RID: 49883 RVA: 0x0005ECD9 File Offset: 0x0005CED9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD5 RID: 15573
			// (get) Token: 0x0600C2DC RID: 49884 RVA: 0x002F91E8 File Offset: 0x002F73E8
			// (set) Token: 0x0600C2DD RID: 49885 RVA: 0x0005ECF8 File Offset: 0x0005CEF8
			public unsafe PoliceChatterVO __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceChatterVO>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400840B RID: 33803
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400840C RID: 33804
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400840D RID: 33805
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400840E RID: 33806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400840F RID: 33807
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008410 RID: 33808
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008411 RID: 33809
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008412 RID: 33810
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008413 RID: 33811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
