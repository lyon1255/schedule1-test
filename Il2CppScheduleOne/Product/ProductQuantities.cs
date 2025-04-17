using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AA RID: 1450
	public static class ProductQuantities : Object
	{
		// Token: 0x06007F95 RID: 32661 RVA: 0x00222CEC File Offset: 0x00220EEC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductQuantities()
		{
			Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductQuantities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr);
			ProductQuantities.NativeFieldInfoPtr_BagQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "BagQuantity");
			ProductQuantities.NativeFieldInfoPtr_JarQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "JarQuantity");
			ProductQuantities.NativeFieldInfoPtr_BrickQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "BrickQuantity");
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x0003C6E7 File Offset: 0x0003A8E7
		public ProductQuantities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x06007F97 RID: 32663 RVA: 0x00222D58 File Offset: 0x00220F58
		// (set) Token: 0x06007F98 RID: 32664 RVA: 0x0003C6F0 File Offset: 0x0003A8F0
		public unsafe static int BagQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_BagQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_BagQuantity, (void*)(&value));
			}
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x06007F99 RID: 32665 RVA: 0x00222D74 File Offset: 0x00220F74
		// (set) Token: 0x06007F9A RID: 32666 RVA: 0x0003C6FE File Offset: 0x0003A8FE
		public unsafe static int JarQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_JarQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_JarQuantity, (void*)(&value));
			}
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x06007F9B RID: 32667 RVA: 0x00222D90 File Offset: 0x00220F90
		// (set) Token: 0x06007F9C RID: 32668 RVA: 0x0003C70C File Offset: 0x0003A90C
		public unsafe static int BrickQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_BrickQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_BrickQuantity, (void*)(&value));
			}
		}

		// Token: 0x040056F9 RID: 22265
		private static readonly IntPtr NativeFieldInfoPtr_BagQuantity;

		// Token: 0x040056FA RID: 22266
		private static readonly IntPtr NativeFieldInfoPtr_JarQuantity;

		// Token: 0x040056FB RID: 22267
		private static readonly IntPtr NativeFieldInfoPtr_BrickQuantity;
	}
}
