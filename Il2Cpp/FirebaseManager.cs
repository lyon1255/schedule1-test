using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Il2Cpp
{
	// Token: 0x02000017 RID: 23
	public class FirebaseManager : MonoBehaviour
	{
		// Token: 0x06000186 RID: 390 RVA: 0x0007565C File Offset: 0x0007385C
		// Note: this type is marked as 'beforefieldinit'.
		static FirebaseManager()
		{
			Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FirebaseManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr);
			FirebaseManager.NativeMethodInfoPtr_FetchActiveVote_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr, 100663425);
			FirebaseManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr, 100663426);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000756B4 File Offset: 0x000738B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72102, XrefRangeEnd = 72106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FetchActiveVote()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager.NativeMethodInfoPtr_FetchActiveVote_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000756F4 File Offset: 0x000738F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirebaseManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002D93 File Offset: 0x00000F93
		public FirebaseManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_FetchActiveVote_Private_IEnumerator_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007A8 RID: 1960
		[ObfuscatedName("FirebaseManager+<FetchActiveVote>d__0")]
		public sealed class _FetchActiveVote_d__0 : Il2CppSystem.Object
		{
			// Token: 0x0600B934 RID: 47412 RVA: 0x002DFD5C File Offset: 0x002DDF5C
			// Note: this type is marked as 'beforefieldinit'.
			static _FetchActiveVote_d__0()
			{
				Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirebaseManager>.NativeClassPtr, "<FetchActiveVote>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr);
				FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, "<>1__state");
				FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, "<>2__current");
				FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, "<request>5__2");
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663427);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663428);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663429);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663430);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663431);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663432);
				FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr, 100663433);
			}

			// Token: 0x0600B935 RID: 47413 RVA: 0x002DFE50 File Offset: 0x002DE050
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FetchActiveVote_d__0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirebaseManager._FetchActiveVote_d__0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B936 RID: 47414 RVA: 0x002DFE98 File Offset: 0x002DE098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72056, XrefRangeEnd = 72061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B937 RID: 47415 RVA: 0x002DFECC File Offset: 0x002DE0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72061, XrefRangeEnd = 72094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B938 RID: 47416 RVA: 0x002DFF08 File Offset: 0x002DE108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72094, XrefRangeEnd = 72097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003929 RID: 14633
			// (get) Token: 0x0600B939 RID: 47417 RVA: 0x002DFF3C File Offset: 0x002DE13C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B93A RID: 47418 RVA: 0x002DFF7C File Offset: 0x002DE17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72097, XrefRangeEnd = 72102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700392A RID: 14634
			// (get) Token: 0x0600B93B RID: 47419 RVA: 0x002DFFB0 File Offset: 0x002DE1B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirebaseManager._FetchActiveVote_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B93C RID: 47420 RVA: 0x0005A8D1 File Offset: 0x00058AD1
			public _FetchActiveVote_d__0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003926 RID: 14630
			// (get) Token: 0x0600B93D RID: 47421 RVA: 0x002DFFF0 File Offset: 0x002DE1F0
			// (set) Token: 0x0600B93E RID: 47422 RVA: 0x0005A8DA File Offset: 0x00058ADA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003927 RID: 14631
			// (get) Token: 0x0600B93F RID: 47423 RVA: 0x002E0018 File Offset: 0x002DE218
			// (set) Token: 0x0600B940 RID: 47424 RVA: 0x0005A8F5 File Offset: 0x00058AF5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003928 RID: 14632
			// (get) Token: 0x0600B941 RID: 47425 RVA: 0x002E0048 File Offset: 0x002DE248
			// (set) Token: 0x0600B942 RID: 47426 RVA: 0x0005A914 File Offset: 0x00058B14
			public unsafe UnityWebRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FirebaseManager._FetchActiveVote_d__0.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007CF9 RID: 31993
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007CFA RID: 31994
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007CFB RID: 31995
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04007CFC RID: 31996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007CFD RID: 31997
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007CFE RID: 31998
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007CFF RID: 31999
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007D00 RID: 32000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D01 RID: 32001
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D02 RID: 32002
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
