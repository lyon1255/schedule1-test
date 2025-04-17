using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B8 RID: 952
	public class ReflectionProbeUpdater : MonoBehaviour
	{
		// Token: 0x06004A33 RID: 18995 RVA: 0x00168380 File Offset: 0x00166580
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbeUpdater()
		{
			Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "ReflectionProbeUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr);
			ReflectionProbeUpdater.NativeFieldInfoPtr_Probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "Probe");
			ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "renderQueue");
			ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "RenderRoutine");
			ReflectionProbeUpdater.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672493);
			ReflectionProbeUpdater.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672494);
			ReflectionProbeUpdater.NativeMethodInfoPtr_UpdateProbe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672495);
			ReflectionProbeUpdater.NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672496);
			ReflectionProbeUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100672497);
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00168450 File Offset: 0x00166650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163757, XrefRangeEnd = 163765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00168484 File Offset: 0x00166684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163765, XrefRangeEnd = 163809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x001684B8 File Offset: 0x001666B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163809, XrefRangeEnd = 163822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProbe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_UpdateProbe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x001684EC File Offset: 0x001666EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163822, XrefRangeEnd = 163826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x0016852C File Offset: 0x0016672C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionProbeUpdater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x00023CA8 File Offset: 0x00021EA8
		public ReflectionProbeUpdater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06004A3A RID: 19002 RVA: 0x00168568 File Offset: 0x00166768
		// (set) Token: 0x06004A3B RID: 19003 RVA: 0x00023CB1 File Offset: 0x00021EB1
		public unsafe ReflectionProbe Probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater.NativeFieldInfoPtr_Probe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater.NativeFieldInfoPtr_Probe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06004A3C RID: 19004 RVA: 0x00168598 File Offset: 0x00166798
		// (set) Token: 0x06004A3D RID: 19005 RVA: 0x00023CD0 File Offset: 0x00021ED0
		public unsafe static List<ReflectionProbe> renderQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ReflectionProbe>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06004A3E RID: 19006 RVA: 0x001685C0 File Offset: 0x001667C0
		// (set) Token: 0x06004A3F RID: 19007 RVA: 0x00023CE2 File Offset: 0x00021EE2
		public unsafe static Coroutine RenderRoutine
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeFieldInfoPtr_Probe;

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeFieldInfoPtr_renderQueue;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeFieldInfoPtr_RenderRoutine;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProbe_Private_Void_0;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0;

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000986 RID: 2438
		[ObfuscatedName("ScheduleOne.Lighting.ReflectionProbeUpdater+<ProcessQueue>d__6")]
		public sealed class _ProcessQueue_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600CA32 RID: 51762 RVA: 0x0030E75C File Offset: 0x0030C95C
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessQueue_d__6()
			{
				Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "<ProcessQueue>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<>1__state");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<>2__current");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<renderDuration_Frames>5__2");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<i>5__3");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672499);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672500);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672501);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672502);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672503);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100672504);
			}

			// Token: 0x0600CA33 RID: 51763 RVA: 0x0030E850 File Offset: 0x0030CA50
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessQueue_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA34 RID: 51764 RVA: 0x0030E898 File Offset: 0x0030CA98
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA35 RID: 51765 RVA: 0x0030E8CC File Offset: 0x0030CACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163730, XrefRangeEnd = 163752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F06 RID: 16134
			// (get) Token: 0x0600CA36 RID: 51766 RVA: 0x0030E908 File Offset: 0x0030CB08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA37 RID: 51767 RVA: 0x0030E948 File Offset: 0x0030CB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163752, XrefRangeEnd = 163757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F07 RID: 16135
			// (get) Token: 0x0600CA38 RID: 51768 RVA: 0x0030E97C File Offset: 0x0030CB7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA39 RID: 51769 RVA: 0x000624F3 File Offset: 0x000606F3
			public _ProcessQueue_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F02 RID: 16130
			// (get) Token: 0x0600CA3A RID: 51770 RVA: 0x0030E9BC File Offset: 0x0030CBBC
			// (set) Token: 0x0600CA3B RID: 51771 RVA: 0x000624FC File Offset: 0x000606FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F03 RID: 16131
			// (get) Token: 0x0600CA3C RID: 51772 RVA: 0x0030E9E4 File Offset: 0x0030CBE4
			// (set) Token: 0x0600CA3D RID: 51773 RVA: 0x00062517 File Offset: 0x00060717
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F04 RID: 16132
			// (get) Token: 0x0600CA3E RID: 51774 RVA: 0x0030EA14 File Offset: 0x0030CC14
			// (set) Token: 0x0600CA3F RID: 51775 RVA: 0x00062536 File Offset: 0x00060736
			public unsafe int _renderDuration_Frames_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2)) = value;
				}
			}

			// Token: 0x17003F05 RID: 16133
			// (get) Token: 0x0600CA40 RID: 51776 RVA: 0x0030EA3C File Offset: 0x0030CC3C
			// (set) Token: 0x0600CA41 RID: 51777 RVA: 0x00062551 File Offset: 0x00060751
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040088C6 RID: 35014
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088C7 RID: 35015
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088C8 RID: 35016
			private static readonly IntPtr NativeFieldInfoPtr__renderDuration_Frames_5__2;

			// Token: 0x040088C9 RID: 35017
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040088CA RID: 35018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088CB RID: 35019
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088CC RID: 35020
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088CD RID: 35021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088CE RID: 35022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088CF RID: 35023
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
