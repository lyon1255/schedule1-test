using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000734 RID: 1844
	public class CocaineVisuals : MonoBehaviour
	{
		// Token: 0x0600A8EA RID: 43242 RVA: 0x002A2EB8 File Offset: 0x002A10B8
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineVisuals()
		{
			Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CocaineVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr);
			CocaineVisuals.NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, "Meshes");
			CocaineVisuals.NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, 100683992);
			CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, 100683993);
		}

		// Token: 0x0600A8EB RID: 43243 RVA: 0x002A2F24 File Offset: 0x002A1124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293647, XrefRangeEnd = 293649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(CocaineDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineVisuals.NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x002A2F68 File Offset: 0x002A1168
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x000532EC File Offset: 0x000514EC
		public CocaineVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600A8EE RID: 43246 RVA: 0x002A2FA4 File Offset: 0x002A11A4
		// (set) Token: 0x0600A8EF RID: 43247 RVA: 0x000532F5 File Offset: 0x000514F5
		public unsafe Il2CppReferenceArray<MeshRenderer> Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineVisuals.NativeFieldInfoPtr_Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineVisuals.NativeFieldInfoPtr_Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007161 RID: 29025
		private static readonly IntPtr NativeFieldInfoPtr_Meshes;

		// Token: 0x04007162 RID: 29026
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0;

		// Token: 0x04007163 RID: 29027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
