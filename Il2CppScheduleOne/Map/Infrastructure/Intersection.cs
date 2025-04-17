using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x02000788 RID: 1928
	public class Intersection : MonoBehaviour
	{
		// Token: 0x0600B68B RID: 46731 RVA: 0x002D51C0 File Offset: 0x002D33C0
		// Note: this type is marked as 'beforefieldinit'.
		static Intersection()
		{
			Il2CppClassPointerStore<Intersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "Intersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intersection>.NativeClassPtr);
			Intersection.NativeFieldInfoPtr_path1Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Lights");
			Intersection.NativeFieldInfoPtr_path2Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Lights");
			Intersection.NativeFieldInfoPtr_path1Obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Obstacles");
			Intersection.NativeFieldInfoPtr_path2Obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Obstacles");
			Intersection.NativeFieldInfoPtr_path1Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Time");
			Intersection.NativeFieldInfoPtr_path2Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Time");
			Intersection.NativeFieldInfoPtr_timeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "timeOffset");
			Intersection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685735);
			Intersection.NativeMethodInfoPtr_Run_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685736);
			Intersection.NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685737);
			Intersection.NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685738);
			Intersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100685739);
		}

		// Token: 0x0600B68C RID: 46732 RVA: 0x002D52E0 File Offset: 0x002D34E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311270, XrefRangeEnd = 311281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Intersection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x002D531C File Offset: 0x002D351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311281, XrefRangeEnd = 311286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_Run_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x002D535C File Offset: 0x002D355C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311328, RefRangeEnd = 311329, XrefRangeStart = 311286, XrefRangeEnd = 311328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath1Lights(TrafficLight.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B68F RID: 46735 RVA: 0x002D539C File Offset: 0x002D359C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311329, XrefRangeEnd = 311371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath2Lights(TrafficLight.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x002D53DC File Offset: 0x002D35DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311371, XrefRangeEnd = 311396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intersection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B691 RID: 46737 RVA: 0x00059A2B File Offset: 0x00057C2B
		public Intersection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600B692 RID: 46738 RVA: 0x002D5418 File Offset: 0x002D3618
		// (set) Token: 0x0600B693 RID: 46739 RVA: 0x00059A34 File Offset: 0x00057C34
		public unsafe List<TrafficLight> path1Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrafficLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600B694 RID: 46740 RVA: 0x002D5448 File Offset: 0x002D3648
		// (set) Token: 0x0600B695 RID: 46741 RVA: 0x00059A53 File Offset: 0x00057C53
		public unsafe List<TrafficLight> path2Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrafficLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600B696 RID: 46742 RVA: 0x002D5478 File Offset: 0x002D3678
		// (set) Token: 0x0600B697 RID: 46743 RVA: 0x00059A72 File Offset: 0x00057C72
		public unsafe List<GameObject> path1Obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600B698 RID: 46744 RVA: 0x002D54A8 File Offset: 0x002D36A8
		// (set) Token: 0x0600B699 RID: 46745 RVA: 0x00059A91 File Offset: 0x00057C91
		public unsafe List<GameObject> path2Obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600B69A RID: 46746 RVA: 0x002D54D8 File Offset: 0x002D36D8
		// (set) Token: 0x0600B69B RID: 46747 RVA: 0x00059AB0 File Offset: 0x00057CB0
		public unsafe float path1Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Time)) = value;
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600B69C RID: 46748 RVA: 0x002D5500 File Offset: 0x002D3700
		// (set) Token: 0x0600B69D RID: 46749 RVA: 0x00059ACB File Offset: 0x00057CCB
		public unsafe float path2Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Time)) = value;
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600B69E RID: 46750 RVA: 0x002D5528 File Offset: 0x002D3728
		// (set) Token: 0x0600B69F RID: 46751 RVA: 0x00059AE6 File Offset: 0x00057CE6
		public unsafe float timeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_timeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_timeOffset)) = value;
			}
		}

		// Token: 0x04007AF7 RID: 31479
		private static readonly IntPtr NativeFieldInfoPtr_path1Lights;

		// Token: 0x04007AF8 RID: 31480
		private static readonly IntPtr NativeFieldInfoPtr_path2Lights;

		// Token: 0x04007AF9 RID: 31481
		private static readonly IntPtr NativeFieldInfoPtr_path1Obstacles;

		// Token: 0x04007AFA RID: 31482
		private static readonly IntPtr NativeFieldInfoPtr_path2Obstacles;

		// Token: 0x04007AFB RID: 31483
		private static readonly IntPtr NativeFieldInfoPtr_path1Time;

		// Token: 0x04007AFC RID: 31484
		private static readonly IntPtr NativeFieldInfoPtr_path2Time;

		// Token: 0x04007AFD RID: 31485
		private static readonly IntPtr NativeFieldInfoPtr_timeOffset;

		// Token: 0x04007AFE RID: 31486
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007AFF RID: 31487
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_IEnumerator_0;

		// Token: 0x04007B00 RID: 31488
		private static readonly IntPtr NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0;

		// Token: 0x04007B01 RID: 31489
		private static readonly IntPtr NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0;

		// Token: 0x04007B02 RID: 31490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C08 RID: 3080
		[ObfuscatedName("ScheduleOne.Map.Infrastructure.Intersection+<Run>d__8")]
		public sealed class _Run_d__8 : Il2CppSystem.Object
		{
			// Token: 0x0600E02B RID: 57387 RVA: 0x0034C854 File Offset: 0x0034AA54
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__8()
			{
				Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "<Run>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr);
				Intersection._Run_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>1__state");
				Intersection._Run_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>2__current");
				Intersection._Run_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, "<>4__this");
				Intersection._Run_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685740);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685741);
				Intersection._Run_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685742);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685743);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685744);
				Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr, 100685745);
			}

			// Token: 0x0600E02C RID: 57388 RVA: 0x0034C934 File Offset: 0x0034AB34
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Run_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intersection._Run_d__8>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E02D RID: 57389 RVA: 0x0034C97C File Offset: 0x0034AB7C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E02E RID: 57390 RVA: 0x0034C9B0 File Offset: 0x0034ABB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311254, XrefRangeEnd = 311265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004579 RID: 17785
			// (get) Token: 0x0600E02F RID: 57391 RVA: 0x0034C9EC File Offset: 0x0034ABEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E030 RID: 57392 RVA: 0x0034CA2C File Offset: 0x0034AC2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311265, XrefRangeEnd = 311270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700457A RID: 17786
			// (get) Token: 0x0600E031 RID: 57393 RVA: 0x0034CA60 File Offset: 0x0034AC60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E032 RID: 57394 RVA: 0x0006D490 File Offset: 0x0006B690
			public _Run_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004576 RID: 17782
			// (get) Token: 0x0600E033 RID: 57395 RVA: 0x0034CAA0 File Offset: 0x0034ACA0
			// (set) Token: 0x0600E034 RID: 57396 RVA: 0x0006D499 File Offset: 0x0006B699
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004577 RID: 17783
			// (get) Token: 0x0600E035 RID: 57397 RVA: 0x0034CAC8 File Offset: 0x0034ACC8
			// (set) Token: 0x0600E036 RID: 57398 RVA: 0x0006D4B4 File Offset: 0x0006B6B4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004578 RID: 17784
			// (get) Token: 0x0600E037 RID: 57399 RVA: 0x0034CAF8 File Offset: 0x0034ACF8
			// (set) Token: 0x0600E038 RID: 57400 RVA: 0x0006D4D3 File Offset: 0x0006B6D3
			public unsafe Intersection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Intersection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009623 RID: 38435
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009624 RID: 38436
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009625 RID: 38437
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009626 RID: 38438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009627 RID: 38439
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009628 RID: 38440
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009629 RID: 38441
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400962A RID: 38442
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400962B RID: 38443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
