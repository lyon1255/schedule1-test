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
	// Token: 0x02000162 RID: 354
	public class MaterialIconCreator : IconCreator
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x000C955C File Offset: 0x000C775C
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialIconCreator()
		{
			Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "MaterialIconCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr);
			MaterialIconCreator.NativeFieldInfoPtr_targetRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, "targetRenderer");
			MaterialIconCreator.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, "materials");
			MaterialIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100666284);
			MaterialIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100666285);
			MaterialIconCreator.NativeMethodInfoPtr_BuildIconsRotine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100666286);
			MaterialIconCreator.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100666287);
			MaterialIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100666288);
			MaterialIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100666289);
			MaterialIconCreator.NativeMethodInfoPtr__BuildIconsRotine_b__4_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100666290);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x000C9640 File Offset: 0x000C7840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101171, XrefRangeEnd = 101177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BuildIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x000C967C File Offset: 0x000C787C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101177, XrefRangeEnd = 101185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000C96C4 File Offset: 0x000C78C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101185, XrefRangeEnd = 101190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BuildIconsRotine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator.NativeMethodInfoPtr_BuildIconsRotine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x000C9704 File Offset: 0x000C7904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101190, XrefRangeEnd = 101195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x000C9738 File Offset: 0x000C7938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101195, XrefRangeEnd = 101204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000C9774 File Offset: 0x000C7974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialIconCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000C97B0 File Offset: 0x000C79B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101204, XrefRangeEnd = 101205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BuildIconsRotine_b__4_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator.NativeMethodInfoPtr__BuildIconsRotine_b__4_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0001050C File Offset: 0x0000E70C
		public MaterialIconCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x000C97EC File Offset: 0x000C79EC
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x00010515 File Offset: 0x0000E715
		public unsafe Renderer targetRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator.NativeFieldInfoPtr_targetRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator.NativeFieldInfoPtr_targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x000C981C File Offset: 0x000C7A1C
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00010534 File Offset: 0x0000E734
		public unsafe Il2CppReferenceArray<Material> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeFieldInfoPtr_targetRenderer;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_BuildIconsRotine_Private_IEnumerator_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr__BuildIconsRotine_b__4_0_Private_Boolean_0;

		// Token: 0x02000866 RID: 2150
		[ObfuscatedName("ItemIconCreator.MaterialIconCreator+<BuildIconsRotine>d__4")]
		public sealed class _BuildIconsRotine_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600C0F8 RID: 49400 RVA: 0x002F2154 File Offset: 0x002F0354
			// Note: this type is marked as 'beforefieldinit'.
			static _BuildIconsRotine_d__4()
			{
				Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, "<BuildIconsRotine>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, "<>1__state");
				MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, "<>2__current");
				MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, "<>4__this");
				MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, "<i>5__2");
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100666291);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100666292);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100666293);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100666294);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100666295);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100666296);
			}

			// Token: 0x0600C0F9 RID: 49401 RVA: 0x002F2248 File Offset: 0x002F0448
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BuildIconsRotine_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C0FA RID: 49402 RVA: 0x002F2290 File Offset: 0x002F0490
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C0FB RID: 49403 RVA: 0x002F22C4 File Offset: 0x002F04C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101094, XrefRangeEnd = 101166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C23 RID: 15395
			// (get) Token: 0x0600C0FC RID: 49404 RVA: 0x002F2300 File Offset: 0x002F0500
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C0FD RID: 49405 RVA: 0x002F2340 File Offset: 0x002F0540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101166, XrefRangeEnd = 101171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C24 RID: 15396
			// (get) Token: 0x0600C0FE RID: 49406 RVA: 0x002F2374 File Offset: 0x002F0574
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C0FF RID: 49407 RVA: 0x0005E57C File Offset: 0x0005C77C
			public _BuildIconsRotine_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C1F RID: 15391
			// (get) Token: 0x0600C100 RID: 49408 RVA: 0x002F23B4 File Offset: 0x002F05B4
			// (set) Token: 0x0600C101 RID: 49409 RVA: 0x0005E585 File Offset: 0x0005C785
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C20 RID: 15392
			// (get) Token: 0x0600C102 RID: 49410 RVA: 0x002F23DC File Offset: 0x002F05DC
			// (set) Token: 0x0600C103 RID: 49411 RVA: 0x0005E5A0 File Offset: 0x0005C7A0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C21 RID: 15393
			// (get) Token: 0x0600C104 RID: 49412 RVA: 0x002F240C File Offset: 0x002F060C
			// (set) Token: 0x0600C105 RID: 49413 RVA: 0x0005E5BF File Offset: 0x0005C7BF
			public unsafe MaterialIconCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialIconCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C22 RID: 15394
			// (get) Token: 0x0600C106 RID: 49414 RVA: 0x002F243C File Offset: 0x002F063C
			// (set) Token: 0x0600C107 RID: 49415 RVA: 0x0005E5DE File Offset: 0x0005C7DE
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040082B6 RID: 33462
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040082B7 RID: 33463
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040082B8 RID: 33464
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040082B9 RID: 33465
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040082BA RID: 33466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040082BB RID: 33467
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082BC RID: 33468
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040082BD RID: 33469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040082BE RID: 33470
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082BF RID: 33471
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
