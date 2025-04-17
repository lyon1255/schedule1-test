using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000533 RID: 1331
	public class DelayedUnityEvent : MonoBehaviour
	{
		// Token: 0x0600769F RID: 30367 RVA: 0x002039D4 File Offset: 0x00201BD4
		// Note: this type is marked as 'beforefieldinit'.
		static DelayedUnityEvent()
		{
			Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DelayedUnityEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr);
			DelayedUnityEvent.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, "Delay");
			DelayedUnityEvent.NativeFieldInfoPtr_onDelayStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, "onDelayStart");
			DelayedUnityEvent.NativeFieldInfoPtr_onDelayedExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, "onDelayedExecute");
			DelayedUnityEvent.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, 100678233);
			DelayedUnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, 100678234);
			DelayedUnityEvent.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, 100678235);
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00203A7C File Offset: 0x00201C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230904, XrefRangeEnd = 230910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00203AB0 File Offset: 0x00201CB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74368, RefRangeEnd = 74372, XrefRangeStart = 74368, XrefRangeEnd = 74372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayedUnityEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00203AEC File Offset: 0x00201CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230910, XrefRangeEnd = 230915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x0003836F File Offset: 0x0003656F
		public DelayedUnityEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x060076A4 RID: 30372 RVA: 0x00203B2C File Offset: 0x00201D2C
		// (set) Token: 0x060076A5 RID: 30373 RVA: 0x00038378 File Offset: 0x00036578
		public unsafe float Delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_Delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_Delay)) = value;
			}
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x060076A6 RID: 30374 RVA: 0x00203B54 File Offset: 0x00201D54
		// (set) Token: 0x060076A7 RID: 30375 RVA: 0x00038393 File Offset: 0x00036593
		public unsafe UnityEvent onDelayStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_onDelayStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_onDelayStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x060076A8 RID: 30376 RVA: 0x00203B84 File Offset: 0x00201D84
		// (set) Token: 0x060076A9 RID: 30377 RVA: 0x000383B2 File Offset: 0x000365B2
		public unsafe UnityEvent onDelayedExecute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_onDelayedExecute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.NativeFieldInfoPtr_onDelayedExecute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005103 RID: 20739
		private static readonly IntPtr NativeFieldInfoPtr_Delay;

		// Token: 0x04005104 RID: 20740
		private static readonly IntPtr NativeFieldInfoPtr_onDelayStart;

		// Token: 0x04005105 RID: 20741
		private static readonly IntPtr NativeFieldInfoPtr_onDelayedExecute;

		// Token: 0x04005106 RID: 20742
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x04005107 RID: 20743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005108 RID: 20744
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A9B RID: 2715
		[ObfuscatedName("ScheduleOne.Tools.DelayedUnityEvent+<<Execute>g__Wait|3_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D2D5 RID: 53973 RVA: 0x00326808 File Offset: 0x00324A08
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique()
			{
				Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelayedUnityEvent>.NativeClassPtr, "<<Execute>g__Wait|3_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>1__state");
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>2__current");
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>4__this");
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678236);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678237);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678238);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678239);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678240);
				DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100678241);
			}

			// Token: 0x0600D2D6 RID: 53974 RVA: 0x003268E8 File Offset: 0x00324AE8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2D7 RID: 53975 RVA: 0x00326930 File Offset: 0x00324B30
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2D8 RID: 53976 RVA: 0x00326964 File Offset: 0x00324B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230893, XrefRangeEnd = 230899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004168 RID: 16744
			// (get) Token: 0x0600D2D9 RID: 53977 RVA: 0x003269A0 File Offset: 0x00324BA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2DA RID: 53978 RVA: 0x003269E0 File Offset: 0x00324BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230899, XrefRangeEnd = 230904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004169 RID: 16745
			// (get) Token: 0x0600D2DB RID: 53979 RVA: 0x00326A14 File Offset: 0x00324C14
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2DC RID: 53980 RVA: 0x00066A15 File Offset: 0x00064C15
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004165 RID: 16741
			// (get) Token: 0x0600D2DD RID: 53981 RVA: 0x00326A54 File Offset: 0x00324C54
			// (set) Token: 0x0600D2DE RID: 53982 RVA: 0x00066A1E File Offset: 0x00064C1E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004166 RID: 16742
			// (get) Token: 0x0600D2DF RID: 53983 RVA: 0x00326A7C File Offset: 0x00324C7C
			// (set) Token: 0x0600D2E0 RID: 53984 RVA: 0x00066A39 File Offset: 0x00064C39
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004167 RID: 16743
			// (get) Token: 0x0600D2E1 RID: 53985 RVA: 0x00326AAC File Offset: 0x00324CAC
			// (set) Token: 0x0600D2E2 RID: 53986 RVA: 0x00066A58 File Offset: 0x00064C58
			public unsafe DelayedUnityEvent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelayedUnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedUnityEvent.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E1A RID: 36378
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E1B RID: 36379
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E1C RID: 36380
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E1D RID: 36381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E1E RID: 36382
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E1F RID: 36383
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E20 RID: 36384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E21 RID: 36385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E22 RID: 36386
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
