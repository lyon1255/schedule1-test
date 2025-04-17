using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054E RID: 1358
	public class SetRendererMaterial : MonoBehaviour
	{
		// Token: 0x060077C9 RID: 30665 RVA: 0x00207194 File Offset: 0x00205394
		// Note: this type is marked as 'beforefieldinit'.
		static SetRendererMaterial()
		{
			Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetRendererMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr);
			SetRendererMaterial.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, "Material");
			SetRendererMaterial.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, 100678369);
			SetRendererMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, 100678370);
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x00207200 File Offset: 0x00205400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231915, XrefRangeEnd = 231924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetRendererMaterial.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x00207234 File Offset: 0x00205434
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetRendererMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetRendererMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x00038BA8 File Offset: 0x00036DA8
		public SetRendererMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x060077CD RID: 30669 RVA: 0x00207270 File Offset: 0x00205470
		// (set) Token: 0x060077CE RID: 30670 RVA: 0x00038BB1 File Offset: 0x00036DB1
		public unsafe Material Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetRendererMaterial.NativeFieldInfoPtr_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetRendererMaterial.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051B5 RID: 20917
		private static readonly IntPtr NativeFieldInfoPtr_Material;

		// Token: 0x040051B6 RID: 20918
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x040051B7 RID: 20919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
