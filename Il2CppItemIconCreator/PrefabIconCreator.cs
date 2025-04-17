using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppItemIconCreator
{
	// Token: 0x02000163 RID: 355
	public class PrefabIconCreator : IconCreator
	{
		// Token: 0x06001CB0 RID: 7344 RVA: 0x000C984C File Offset: 0x000C7A4C
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabIconCreator()
		{
			Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "PrefabIconCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr);
			PrefabIconCreator.NativeFieldInfoPtr_itemsToShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "itemsToShot");
			PrefabIconCreator.NativeFieldInfoPtr_itemPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "itemPosition");
			PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "instantiatedItem");
			PrefabIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666297);
			PrefabIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666298);
			PrefabIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666299);
			PrefabIconCreator.NativeMethodInfoPtr_ClearShit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666300);
			PrefabIconCreator.NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666301);
			PrefabIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666302);
			PrefabIconCreator.NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100666303);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000C9944 File Offset: 0x000C7B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101221, XrefRangeEnd = 101227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BuildIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000C9980 File Offset: 0x000C7B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101227, XrefRangeEnd = 101235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000C99C8 File Offset: 0x000C7BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101235, XrefRangeEnd = 101279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x000C9A04 File Offset: 0x000C7C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101303, RefRangeEnd = 101304, XrefRangeStart = 101279, XrefRangeEnd = 101303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr_ClearShit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000C9A38 File Offset: 0x000C7C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101304, XrefRangeEnd = 101309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BuildAllIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000C9A78 File Offset: 0x000C7C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabIconCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000C9AB4 File Offset: 0x000C7CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BuildAllIcons_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00010553 File Offset: 0x0000E753
		public PrefabIconCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x000C9AF0 File Offset: 0x000C7CF0
		// (set) Token: 0x06001CBA RID: 7354 RVA: 0x0001055C File Offset: 0x0000E75C
		public unsafe Il2CppReferenceArray<GameObject> itemsToShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemsToShot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemsToShot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x000C9B20 File Offset: 0x000C7D20
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0001057B File Offset: 0x0000E77B
		public unsafe Transform itemPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x000C9B50 File Offset: 0x000C7D50
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0001059A File Offset: 0x0000E79A
		public unsafe GameObject instantiatedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_itemsToShot;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_itemPosition;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_instantiatedItem;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr_ClearShit_Private_Void_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0;

		// Token: 0x02000867 RID: 2151
		[ObfuscatedName("ItemIconCreator.PrefabIconCreator+<BuildAllIcons>d__7")]
		public sealed class _BuildAllIcons_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600C108 RID: 49416 RVA: 0x002F2464 File Offset: 0x002F0664
			// Note: this type is marked as 'beforefieldinit'.
			static _BuildAllIcons_d__7()
			{
				Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "<BuildAllIcons>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr);
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>1__state");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>2__current");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>4__this");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<i>5__2");
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666304);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666305);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666306);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666307);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666308);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100666309);
			}

			// Token: 0x0600C109 RID: 49417 RVA: 0x002F2558 File Offset: 0x002F0758
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BuildAllIcons_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C10A RID: 49418 RVA: 0x002F25A0 File Offset: 0x002F07A0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C10B RID: 49419 RVA: 0x002F25D4 File Offset: 0x002F07D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101205, XrefRangeEnd = 101216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C29 RID: 15401
			// (get) Token: 0x0600C10C RID: 49420 RVA: 0x002F2610 File Offset: 0x002F0810
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C10D RID: 49421 RVA: 0x002F2650 File Offset: 0x002F0850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101216, XrefRangeEnd = 101221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C2A RID: 15402
			// (get) Token: 0x0600C10E RID: 49422 RVA: 0x002F2684 File Offset: 0x002F0884
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C10F RID: 49423 RVA: 0x0005E5F9 File Offset: 0x0005C7F9
			public _BuildAllIcons_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C25 RID: 15397
			// (get) Token: 0x0600C110 RID: 49424 RVA: 0x002F26C4 File Offset: 0x002F08C4
			// (set) Token: 0x0600C111 RID: 49425 RVA: 0x0005E602 File Offset: 0x0005C802
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C26 RID: 15398
			// (get) Token: 0x0600C112 RID: 49426 RVA: 0x002F26EC File Offset: 0x002F08EC
			// (set) Token: 0x0600C113 RID: 49427 RVA: 0x0005E61D File Offset: 0x0005C81D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C27 RID: 15399
			// (get) Token: 0x0600C114 RID: 49428 RVA: 0x002F271C File Offset: 0x002F091C
			// (set) Token: 0x0600C115 RID: 49429 RVA: 0x0005E63C File Offset: 0x0005C83C
			public unsafe PrefabIconCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabIconCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C28 RID: 15400
			// (get) Token: 0x0600C116 RID: 49430 RVA: 0x002F274C File Offset: 0x002F094C
			// (set) Token: 0x0600C117 RID: 49431 RVA: 0x0005E65B File Offset: 0x0005C85B
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040082C0 RID: 33472
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040082C1 RID: 33473
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040082C2 RID: 33474
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040082C3 RID: 33475
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040082C4 RID: 33476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040082C5 RID: 33477
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082C6 RID: 33478
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040082C7 RID: 33479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040082C8 RID: 33480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082C9 RID: 33481
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
