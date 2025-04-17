using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000625 RID: 1573
	public class BlackOverlay : Singleton<BlackOverlay>
	{
		// Token: 0x06008A97 RID: 35479 RVA: 0x00244FAC File Offset: 0x002431AC
		// Note: this type is marked as 'beforefieldinit'.
		static BlackOverlay()
		{
			Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BlackOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr);
			BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "<isShown>k__BackingField");
			BlackOverlay.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "canvas");
			BlackOverlay.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "group");
			BlackOverlay.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "fadeRoutine");
			BlackOverlay.NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680515);
			BlackOverlay.NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680516);
			BlackOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680517);
			BlackOverlay.NativeMethodInfoPtr_Open_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680518);
			BlackOverlay.NativeMethodInfoPtr_Close_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680519);
			BlackOverlay.NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680520);
			BlackOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680521);
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x06008A98 RID: 35480 RVA: 0x002450B8 File Offset: 0x002432B8
		// (set) Token: 0x06008A99 RID: 35481 RVA: 0x002450F4 File Offset: 0x002432F4
		public unsafe bool isShown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008A9A RID: 35482 RVA: 0x00245134 File Offset: 0x00243334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254146, XrefRangeEnd = 254152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x00245170 File Offset: 0x00243370
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254158, RefRangeEnd = 254163, XrefRangeStart = 254152, XrefRangeEnd = 254158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(float fadeTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Open_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x002451B0 File Offset: 0x002433B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 254167, RefRangeEnd = 254174, XrefRangeStart = 254163, XrefRangeEnd = 254167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(float fadeTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Close_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x002451F0 File Offset: 0x002433F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254179, RefRangeEnd = 254182, XrefRangeStart = 254174, XrefRangeEnd = 254179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Fade(float endOpacity, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endOpacity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x0024524C File Offset: 0x0024344C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254182, XrefRangeEnd = 254185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x0004246C File Offset: 0x0004066C
		public BlackOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x06008AA0 RID: 35488 RVA: 0x00245288 File Offset: 0x00243488
		// (set) Token: 0x06008AA1 RID: 35489 RVA: 0x00042475 File Offset: 0x00040675
		public unsafe bool _isShown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x06008AA2 RID: 35490 RVA: 0x002452B0 File Offset: 0x002434B0
		// (set) Token: 0x06008AA3 RID: 35491 RVA: 0x00042490 File Offset: 0x00040690
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x06008AA4 RID: 35492 RVA: 0x002452E0 File Offset: 0x002434E0
		// (set) Token: 0x06008AA5 RID: 35493 RVA: 0x000424AF File Offset: 0x000406AF
		public unsafe CanvasGroup group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x06008AA6 RID: 35494 RVA: 0x00245310 File Offset: 0x00243510
		// (set) Token: 0x06008AA7 RID: 35495 RVA: 0x000424CE File Offset: 0x000406CE
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_fadeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E04 RID: 24068
		private static readonly IntPtr NativeFieldInfoPtr__isShown_k__BackingField;

		// Token: 0x04005E05 RID: 24069
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005E06 RID: 24070
		private static readonly IntPtr NativeFieldInfoPtr_group;

		// Token: 0x04005E07 RID: 24071
		private static readonly IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x04005E08 RID: 24072
		private static readonly IntPtr NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0;

		// Token: 0x04005E09 RID: 24073
		private static readonly IntPtr NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0;

		// Token: 0x04005E0A RID: 24074
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005E0B RID: 24075
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Single_0;

		// Token: 0x04005E0C RID: 24076
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Single_0;

		// Token: 0x04005E0D RID: 24077
		private static readonly IntPtr NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0;

		// Token: 0x04005E0E RID: 24078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B11 RID: 2833
		[ObfuscatedName("ScheduleOne.UI.BlackOverlay+<Fade>d__10")]
		public sealed class _Fade_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600D694 RID: 54932 RVA: 0x0033126C File Offset: 0x0032F46C
			// Note: this type is marked as 'beforefieldinit'.
			static _Fade_d__10()
			{
				Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "<Fade>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr);
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>1__state");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>2__current");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>4__this");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "endOpacity");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "fadeTime");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<start>5__2");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<i>5__3");
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680522);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680523);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680524);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680525);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680526);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680527);
			}

			// Token: 0x0600D695 RID: 54933 RVA: 0x0033139C File Offset: 0x0032F59C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Fade_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D696 RID: 54934 RVA: 0x003313E4 File Offset: 0x0032F5E4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D697 RID: 54935 RVA: 0x00331418 File Offset: 0x0032F618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254131, XrefRangeEnd = 254141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004280 RID: 17024
			// (get) Token: 0x0600D698 RID: 54936 RVA: 0x00331454 File Offset: 0x0032F654
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D699 RID: 54937 RVA: 0x00331494 File Offset: 0x0032F694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254141, XrefRangeEnd = 254146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004281 RID: 17025
			// (get) Token: 0x0600D69A RID: 54938 RVA: 0x003314C8 File Offset: 0x0032F6C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D69B RID: 54939 RVA: 0x000686B4 File Offset: 0x000668B4
			public _Fade_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004279 RID: 17017
			// (get) Token: 0x0600D69C RID: 54940 RVA: 0x00331508 File Offset: 0x0032F708
			// (set) Token: 0x0600D69D RID: 54941 RVA: 0x000686BD File Offset: 0x000668BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700427A RID: 17018
			// (get) Token: 0x0600D69E RID: 54942 RVA: 0x00331530 File Offset: 0x0032F730
			// (set) Token: 0x0600D69F RID: 54943 RVA: 0x000686D8 File Offset: 0x000668D8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427B RID: 17019
			// (get) Token: 0x0600D6A0 RID: 54944 RVA: 0x00331560 File Offset: 0x0032F760
			// (set) Token: 0x0600D6A1 RID: 54945 RVA: 0x000686F7 File Offset: 0x000668F7
			public unsafe BlackOverlay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackOverlay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427C RID: 17020
			// (get) Token: 0x0600D6A2 RID: 54946 RVA: 0x00331590 File Offset: 0x0032F790
			// (set) Token: 0x0600D6A3 RID: 54947 RVA: 0x00068716 File Offset: 0x00066916
			public unsafe float endOpacity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity)) = value;
				}
			}

			// Token: 0x1700427D RID: 17021
			// (get) Token: 0x0600D6A4 RID: 54948 RVA: 0x003315B8 File Offset: 0x0032F7B8
			// (set) Token: 0x0600D6A5 RID: 54949 RVA: 0x00068731 File Offset: 0x00066931
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x1700427E RID: 17022
			// (get) Token: 0x0600D6A6 RID: 54950 RVA: 0x003315E0 File Offset: 0x0032F7E0
			// (set) Token: 0x0600D6A7 RID: 54951 RVA: 0x0006874C File Offset: 0x0006694C
			public unsafe float _start_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2)) = value;
				}
			}

			// Token: 0x1700427F RID: 17023
			// (get) Token: 0x0600D6A8 RID: 54952 RVA: 0x00331608 File Offset: 0x0032F808
			// (set) Token: 0x0600D6A9 RID: 54953 RVA: 0x00068767 File Offset: 0x00066967
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009053 RID: 36947
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009054 RID: 36948
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009055 RID: 36949
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009056 RID: 36950
			private static readonly IntPtr NativeFieldInfoPtr_endOpacity;

			// Token: 0x04009057 RID: 36951
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x04009058 RID: 36952
			private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

			// Token: 0x04009059 RID: 36953
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400905A RID: 36954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400905B RID: 36955
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400905C RID: 36956
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400905D RID: 36957
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400905E RID: 36958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400905F RID: 36959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
