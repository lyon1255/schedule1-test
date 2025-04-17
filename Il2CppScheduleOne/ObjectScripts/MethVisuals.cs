using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000735 RID: 1845
	public class MethVisuals : MonoBehaviour
	{
		// Token: 0x0600A8F0 RID: 43248 RVA: 0x002A2FD4 File Offset: 0x002A11D4
		// Note: this type is marked as 'beforefieldinit'.
		static MethVisuals()
		{
			Il2CppClassPointerStore<MethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MethVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr);
			MethVisuals.NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, "Meshes");
			MethVisuals.NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, 100683994);
			MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, 100683995);
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x002A3040 File Offset: 0x002A1240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(MethDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethVisuals.NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x002A3084 File Offset: 0x002A1284
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x00053314 File Offset: 0x00051514
		public MethVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600A8F4 RID: 43252 RVA: 0x002A30C0 File Offset: 0x002A12C0
		// (set) Token: 0x0600A8F5 RID: 43253 RVA: 0x0005331D File Offset: 0x0005151D
		public unsafe Il2CppReferenceArray<MeshRenderer> Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethVisuals.NativeFieldInfoPtr_Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethVisuals.NativeFieldInfoPtr_Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007164 RID: 29028
		private static readonly IntPtr NativeFieldInfoPtr_Meshes;

		// Token: 0x04007165 RID: 29029
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0;

		// Token: 0x04007166 RID: 29030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
