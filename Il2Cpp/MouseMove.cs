using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000040 RID: 64
	public class MouseMove : MonoBehaviour
	{
		// Token: 0x0600053C RID: 1340 RVA: 0x0007F778 File Offset: 0x0007D978
		// Note: this type is marked as 'beforefieldinit'.
		static MouseMove()
		{
			Il2CppClassPointerStore<MouseMove>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MouseMove");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseMove>.NativeClassPtr);
			MouseMove.NativeFieldInfoPtr__sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, "_sensitivity");
			MouseMove.NativeFieldInfoPtr__originalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, "_originalPos");
			MouseMove.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, 100663739);
			MouseMove.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, 100663740);
			MouseMove.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, 100663741);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0007F80C File Offset: 0x0007DA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74787, XrefRangeEnd = 74789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMove.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0007F840 File Offset: 0x0007DA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74789, XrefRangeEnd = 74794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMove.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0007F874 File Offset: 0x0007DA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74794, XrefRangeEnd = 74795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseMove() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseMove>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMove.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00005222 File Offset: 0x00003422
		public MouseMove(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0007F8B0 File Offset: 0x0007DAB0
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0000522B File Offset: 0x0000342B
		public unsafe float _sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseMove.NativeFieldInfoPtr__sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseMove.NativeFieldInfoPtr__sensitivity)) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0007F8D8 File Offset: 0x0007DAD8
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00005246 File Offset: 0x00003446
		public unsafe Vector3 _originalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseMove.NativeFieldInfoPtr__originalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseMove.NativeFieldInfoPtr__originalPos)) = value;
			}
		}

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr__sensitivity;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr__originalPos;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
