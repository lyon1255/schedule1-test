using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Demos
{
	// Token: 0x0200013A RID: 314
	public class Demo : MonoBehaviour
	{
		// Token: 0x06001A49 RID: 6729 RVA: 0x000C2AD8 File Offset: 0x000C0CD8
		// Note: this type is marked as 'beforefieldinit'.
		static Demo()
		{
			Il2CppClassPointerStore<Demo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Demos", "Demo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Demo>.NativeClassPtr);
			Demo.NativeFieldInfoPtr_lutTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "lutTexture");
			Demo.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100666087);
			Demo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100666088);
			Demo.NativeMethodInfoPtr_UpdateText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100666089);
			Demo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100666090);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x000C2B6C File Offset: 0x000C0D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97049, XrefRangeEnd = 97050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Demo.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x000C2BA0 File Offset: 0x000C0DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97050, XrefRangeEnd = 97117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Demo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x000C2BD4 File Offset: 0x000C0DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97132, RefRangeEnd = 97134, XrefRangeStart = 97117, XrefRangeEnd = 97132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Demo.NativeMethodInfoPtr_UpdateText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000C2C08 File Offset: 0x000C0E08
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Demo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Demo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Demo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0000EE8C File Offset: 0x0000D08C
		public Demo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x000C2C44 File Offset: 0x000C0E44
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x0000EE95 File Offset: 0x0000D095
		public unsafe Texture lutTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Demo.NativeFieldInfoPtr_lutTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Demo.NativeFieldInfoPtr_lutTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeFieldInfoPtr_lutTexture;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Private_Void_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
