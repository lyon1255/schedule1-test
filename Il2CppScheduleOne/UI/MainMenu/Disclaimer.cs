using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E5 RID: 1765
	public class Disclaimer : MonoBehaviour
	{
		// Token: 0x06009E32 RID: 40498 RVA: 0x0027FAF4 File Offset: 0x0027DCF4
		// Note: this type is marked as 'beforefieldinit'.
		static Disclaimer()
		{
			Il2CppClassPointerStore<Disclaimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "Disclaimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr);
			Disclaimer.NativeFieldInfoPtr_Shown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, "Shown");
			Disclaimer.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, "Group");
			Disclaimer.NativeFieldInfoPtr_TextGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, "TextGroup");
			Disclaimer.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, "Duration");
			Disclaimer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, 100682704);
			Disclaimer.NativeMethodInfoPtr_Fade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, 100682705);
			Disclaimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, 100682706);
			Disclaimer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, 100682707);
		}

		// Token: 0x06009E33 RID: 40499 RVA: 0x0027FBC4 File Offset: 0x0027DDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279861, XrefRangeEnd = 279878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x0027FBF8 File Offset: 0x0027DDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279878, XrefRangeEnd = 279884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.NativeMethodInfoPtr_Fade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x0027FC2C File Offset: 0x0027DE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279884, XrefRangeEnd = 279885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Disclaimer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E36 RID: 40502 RVA: 0x0027FC68 File Offset: 0x0027DE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279885, XrefRangeEnd = 279890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009E37 RID: 40503 RVA: 0x0004D96B File Offset: 0x0004BB6B
		public Disclaimer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x06009E38 RID: 40504 RVA: 0x0027FCA8 File Offset: 0x0027DEA8
		// (set) Token: 0x06009E39 RID: 40505 RVA: 0x0004D974 File Offset: 0x0004BB74
		public unsafe static bool Shown
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Disclaimer.NativeFieldInfoPtr_Shown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Disclaimer.NativeFieldInfoPtr_Shown, (void*)(&value));
			}
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x06009E3A RID: 40506 RVA: 0x0027FCC4 File Offset: 0x0027DEC4
		// (set) Token: 0x06009E3B RID: 40507 RVA: 0x0004D982 File Offset: 0x0004BB82
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x06009E3C RID: 40508 RVA: 0x0027FCF4 File Offset: 0x0027DEF4
		// (set) Token: 0x06009E3D RID: 40509 RVA: 0x0004D9A1 File Offset: 0x0004BBA1
		public unsafe CanvasGroup TextGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.NativeFieldInfoPtr_TextGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.NativeFieldInfoPtr_TextGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x06009E3E RID: 40510 RVA: 0x0027FD24 File Offset: 0x0027DF24
		// (set) Token: 0x06009E3F RID: 40511 RVA: 0x0004D9C0 File Offset: 0x0004BBC0
		public unsafe float Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.NativeFieldInfoPtr_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.NativeFieldInfoPtr_Duration)) = value;
			}
		}

		// Token: 0x04006A32 RID: 27186
		private static readonly IntPtr NativeFieldInfoPtr_Shown;

		// Token: 0x04006A33 RID: 27187
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04006A34 RID: 27188
		private static readonly IntPtr NativeFieldInfoPtr_TextGroup;

		// Token: 0x04006A35 RID: 27189
		private static readonly IntPtr NativeFieldInfoPtr_Duration;

		// Token: 0x04006A36 RID: 27190
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006A37 RID: 27191
		private static readonly IntPtr NativeMethodInfoPtr_Fade_Private_Void_0;

		// Token: 0x04006A38 RID: 27192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006A39 RID: 27193
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B9A RID: 2970
		[ObfuscatedName("ScheduleOne.UI.MainMenu.Disclaimer+<<Fade>g__Fade|5_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DC4A RID: 56394 RVA: 0x0034182C File Offset: 0x0033FA2C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique()
			{
				Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Disclaimer>.NativeClassPtr, "<<Fade>g__Fade|5_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr);
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, "<>1__state");
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, "<>2__current");
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, "<>4__this");
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, "<i>5__2");
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, 100682708);
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, 100682709);
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, 100682710);
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, 100682711);
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, 100682712);
				Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr, 100682713);
			}

			// Token: 0x0600DC4B RID: 56395 RVA: 0x00341920 File Offset: 0x0033FB20
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC4C RID: 56396 RVA: 0x00341968 File Offset: 0x0033FB68
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC4D RID: 56397 RVA: 0x0034199C File Offset: 0x0033FB9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279850, XrefRangeEnd = 279856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004449 RID: 17481
			// (get) Token: 0x0600DC4E RID: 56398 RVA: 0x003419D8 File Offset: 0x0033FBD8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DC4F RID: 56399 RVA: 0x00341A18 File Offset: 0x0033FC18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279856, XrefRangeEnd = 279861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700444A RID: 17482
			// (get) Token: 0x0600DC50 RID: 56400 RVA: 0x00341A4C File Offset: 0x0033FC4C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DC51 RID: 56401 RVA: 0x0006B4F0 File Offset: 0x000696F0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004445 RID: 17477
			// (get) Token: 0x0600DC52 RID: 56402 RVA: 0x00341A8C File Offset: 0x0033FC8C
			// (set) Token: 0x0600DC53 RID: 56403 RVA: 0x0006B4F9 File Offset: 0x000696F9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004446 RID: 17478
			// (get) Token: 0x0600DC54 RID: 56404 RVA: 0x00341AB4 File Offset: 0x0033FCB4
			// (set) Token: 0x0600DC55 RID: 56405 RVA: 0x0006B514 File Offset: 0x00069714
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004447 RID: 17479
			// (get) Token: 0x0600DC56 RID: 56406 RVA: 0x00341AE4 File Offset: 0x0033FCE4
			// (set) Token: 0x0600DC57 RID: 56407 RVA: 0x0006B533 File Offset: 0x00069733
			public unsafe Disclaimer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Disclaimer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004448 RID: 17480
			// (get) Token: 0x0600DC58 RID: 56408 RVA: 0x00341B14 File Offset: 0x0033FD14
			// (set) Token: 0x0600DC59 RID: 56409 RVA: 0x0006B552 File Offset: 0x00069752
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Disclaimer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDiSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040093A2 RID: 37794
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040093A3 RID: 37795
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040093A4 RID: 37796
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093A5 RID: 37797
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040093A6 RID: 37798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040093A7 RID: 37799
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093A8 RID: 37800
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093A9 RID: 37801
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093AA RID: 37802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093AB RID: 37803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
